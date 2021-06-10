using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    public interface IBook
    {
        string this[int index]
        {
            //mo tả index trong sách
            get;
            set;
        }
        string Title
        {
            //dại dienj cho ten sách
            get;
            set;
        }
        string Author
        {
            //đại diện cho tên tác giả cuốn sách
            get;
            set;
        }
        string Publisher
        {
            //Publisher dai dien cho Năm Xuất bản
            get;
            set;
        }
        string ISBN
        {
            get;
            set;
        }
       int Year
        {
            // ISBN là nam xuat ban
            get;
            set;
        }
        void Show();
        void Input();
    }
   
}
