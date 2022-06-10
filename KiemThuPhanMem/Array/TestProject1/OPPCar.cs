using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class OPPCar
    {
        private int dungTich;
        private double triGia;
        private string maXe, chuXe, moTa;



        public OPPCar()
        {
            
        }

        public OPPCar(string maXe, int dungTich, double triGia, string chuXe, string moTa)
        {
            this.maXe = maXe;
            this.dungTich = dungTich;
            this.triGia = triGia;
            this.chuXe = chuXe;
            this.moTa = moTa;
        }

        public string MaXe { get => maXe; set => maXe = value; }
        public int DungTich { get => dungTich; set => dungTich = value; }
        public double TriGia { get => triGia; set => triGia = value; }
        public string ChuXe { get => chuXe; set => chuXe = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public double tinhThue()
        {
            double thue;
            if (this.DungTich < 100) thue = TriGia * 0.01;
            else if (this.DungTich >= 100 && this.DungTich <= 200) thue = TriGia * 0.03;
            else thue = TriGia * 0.05;
            return thue;
        }

    }
}
