using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_buổi_3
{
    class SoPhuc
    {
        public int Thuc;
        public int Ao;
        public SoPhuc(int Thuc = 0, int Ao = 0)
        {
            this.Thuc = Thuc;
            this.Ao = Ao;
        }
        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc
            {
                Thuc = a.Thuc + b.Thuc,
                Ao = a.Ao + b.Ao
            };
            return soPhuc;
        }

        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc
            {
                Thuc = a.Thuc - b.Thuc,
                Ao = a.Ao - b.Ao
            };
            return soPhuc;
        }
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc
            {
                Thuc = a.Thuc * b.Thuc - a.Ao * b.Ao,
                Ao = a.Thuc * b.Ao + a.Ao * b.Thuc
            };
            return soPhuc;
        }
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc
            {
                Thuc = (a.Thuc * b.Thuc + b.Ao * a.Ao) / (b.Ao * b.Ao + b.Thuc * b.Thuc),
                Ao = (a.Ao * b.Thuc - a.Thuc * b.Ao) / (b.Ao * b.Ao + b.Thuc * b.Thuc)
            };
            return soPhuc;
        }
        public string XuatSP()
        {
            if (this.Ao < 0)
            {
                return "Số Phức: " + this.Thuc;
            }
            else
            {
                return "Số phức : " + this.Thuc + "," + this.Ao + "i";
            }
        }
    }
}
