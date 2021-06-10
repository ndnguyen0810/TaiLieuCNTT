using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookManaging
{
    public class BookList 
    {
        public ArrayList list = new ArrayList();
  
        public void SortByYear()
        {
            list.Sort();
        }
        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

       
        public void InputList()
        {
            int n;
            Console.WriteLine("Amount of book: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }        
        }
      public void SortMultiple()
        {
            list.Sort(new BookComparer());
        }
       

    }
}
