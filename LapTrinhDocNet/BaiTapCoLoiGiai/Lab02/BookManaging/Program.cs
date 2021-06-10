using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList b1 = new BookList();
            BookList b2 = new BookList();

            b1.InputList();
            Console.WriteLine("======================= SHOW LIST =============================");
            b1.ShowList();

            Console.WriteLine("======================= SHOW LIST SORT =============================");
            // b1.SortByTitle();
            b1.SortByYear();
          //  b1.SortMultiple();
            b1.ShowList();
          
            Console.ReadLine();
        }
    }
}
