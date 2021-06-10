using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_buổi_3
{
    class TamGiac
    {
        public int CanhA;
        public int CanhB;
        public int CanhC;
        public TamGiac(int CanhA = 0, int CanhB = 0, int CanhC = 0)
        {
            this.CanhA = CanhA;
            this.CanhB = CanhB;
            this.CanhC = CanhC;
        }
        public int TinhChuVi()
        {
            int CV = 0;
            int KiemtraTG = Kiemtra();
            if (KiemtraTG == 3)
            {
                CV = 2 * this.CanhA + this.CanhC;
                return CV;
            }
            else if (KiemtraTG == 2)
            {
                CV = 3 * this.CanhA;
                return CV;
            }
            else if (KiemtraTG == 1)
            {
                CV = this.CanhA + this.CanhB + this.CanhC;
                return CV;
            }
            else
            {
                return -1;
            }
        }
        public double TinhDienTich()
        {
            double S = 0;
            float C = TinhChuVi();
            float p = C / 2;
            float f = p * (p - this.CanhA) * (p - this.CanhB) * (p - this.CanhC);
          
            S = (float)Math.Sqrt(f);
            return S;
        }
        public int Kiemtra()
        {
            if (this.CanhA < this.CanhB + this.CanhC && this.CanhB < this.CanhA + this.CanhC && this.CanhC < this.CanhA + this.CanhB)
            {
                if (this.CanhA * this.CanhA == this.CanhB * this.CanhB + this.CanhC * this.CanhC
                   || this.CanhB * this.CanhB == this.CanhA * this.CanhA + this.CanhC * this.CanhC
                   || this.CanhC * this.CanhC == this.CanhA * this.CanhA + this.CanhB * this.CanhB)
                {
                    //đây là tam giác vuông
                    return 1;
                }
                else if (this.CanhA == this.CanhB && this.CanhB == this.CanhC)
                {
                    //đây là tam giác đều
                    return 2;
                }
                else if (this.CanhA == this.CanhB || this.CanhA == this.CanhC || this.CanhB == this.CanhC)
                {
                    //đây là tam giác cân   
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
