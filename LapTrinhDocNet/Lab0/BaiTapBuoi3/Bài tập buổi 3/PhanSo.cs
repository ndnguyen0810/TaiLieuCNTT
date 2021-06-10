using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_buổi_3
{
    class PhanSo
    {
        public float Tuso;
        public float Mauso;
        public PhanSo(float Tuso = 0, float Mauso = 0)
        {
            this.Tuso = Tuso;
            if (Mauso != 0)
            {
                this.Mauso = Mauso;
            }
            else
            {
                this.Mauso = 1;
            }
        }
        public void InPhanSo()
        {
            MessageBox.Show("Phân số : " + this.Tuso + "/" + this.Mauso);
        }
        public float UCLN(float m, float n)
        {

            if (m == 0 && n == 0)
                return 1;

            while (m != n)
            {
                if (m > n)
                    m -= n;
                else n -= m;
            }
            return m;
        }
        public void RutGonPhanSo()
        {
            float UCLNPS = UCLN(this.Tuso, this.Mauso);
            this.Tuso /= UCLNPS;
            this.Mauso /= UCLNPS;
        }
        public float USCLN()
        {
            float a = this.Tuso;
            float b = this.Mauso;
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; // a = a - b
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public float USCLN(float a, float b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; // a = a - b
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static PhanSo operator +(PhanSo A, PhanSo B)
        {
            PhanSo phanSo = new PhanSo
            {
                Tuso = A.Tuso * B.Mauso + B.Tuso * A.Mauso,
                Mauso = A.Mauso * B.Mauso
            };
            return phanSo;
        }
        public static PhanSo operator -(PhanSo A, PhanSo B)
        {
            PhanSo phanSo = new PhanSo
            {
                Tuso = A.Tuso * B.Mauso - B.Tuso * A.Mauso,
                Mauso = A.Mauso * B.Mauso
            };
            return phanSo;
        }
        public static PhanSo operator *(PhanSo A, PhanSo B)
        {
            PhanSo phanSo = new PhanSo
            {
                Tuso = A.Tuso * B.Tuso,
                Mauso = A.Mauso * B.Mauso
            };
            return phanSo;
        }
        public static PhanSo operator /(PhanSo A, PhanSo B)
        {
            PhanSo phanSo = new PhanSo
            {
                Tuso = A.Tuso * B.Mauso,
                Mauso = A.Mauso * B.Tuso
            };
            return phanSo;
        }
        public static bool operator >(PhanSo A, PhanSo B)
        {
            bool status = false;
            if (A.Tuso / A.Mauso > B.Tuso / B.Mauso)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public static bool operator <(PhanSo A, PhanSo B)
        {
            bool status = false;
            if (A.Tuso / A.Mauso < B.Tuso / B.Mauso)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public float ChuyenDoi()
        {
            return this.Tuso / this.Mauso;
        }
        public float ChuyenDoi(float TuSo, float MauSo)
        {
            return this.Tuso / this.Mauso;
        }
    }
}
