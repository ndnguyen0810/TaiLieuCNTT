using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookManaging
{
    public class Book:IBook , IComparable<Book>
    {
        #region Định nghĩa dữ liệu;
            public string isbn;
            public string title;
            public string author;
            public string publisher;
            public int year;
            public ArrayList chapter= new ArrayList();
        #endregion

         #region Thực thi giao diện IBook
        public string this[int index]
        {
            get
            {
                if(index>=0&& index<chapter.Count)
                    return (string)chapter[index];
                else{
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index>=0 &&index<=chapter.Count)
                    chapter[index]= value;
                else if(index==chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get  {  return author;     }
            set  {   author = value;   }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }   
        public void Show()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\tTitle " + title);
            Console.WriteLine("\tAuthor " + author);
            Console.WriteLine("\tPublisher " + publisher);
            Console.WriteLine("\tISBN " + isbn);
            Console.WriteLine("\tYear " + year);
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t\t{0}:{1}", i + 1, chapter[i]);
            Console.WriteLine("-----------------------------");

        }
 
 
        public void Input()
        {
          

            Console.Write("Title: ");
                Title = Console.ReadLine();
             //   title = Console.ReadLine();

            Console.Write("Autor: ");
                Author = Console.ReadLine();
             //   author = Console.ReadLine();

            Console.Write("Publisher: ");
                Publisher = Console.ReadLine();

            Console.Write("ISNB :" + isbn);
                ISBN = Console.ReadLine();

            Console.Write("Year: " + year);
                Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapter (finishes with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            }
            while (str.Length > 0);
        }

        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }


        #endregion
    }
    
}

