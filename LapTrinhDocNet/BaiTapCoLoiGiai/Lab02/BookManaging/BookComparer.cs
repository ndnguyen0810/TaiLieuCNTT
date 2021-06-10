using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookManaging
{
    class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            Book b1 = x as Book;
            Book b2 = y as Book;
            if (b1 == null || b2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (b1.year> b2.year)
                    return 1;
                else if (b1.year == b2.year)
                    return 0;
                else
                {
                    return -1;
                }
            }
        }
    }
}
