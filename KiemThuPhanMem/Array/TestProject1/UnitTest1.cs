using NUnit.Framework;
using System.Linq;
using Test;
using TestProject;

namespace TestProject1
{
    public class Tests
    {
        int[] arr = { 5, 4, 3, 7, 6, 2, 1, 8, 0, 9 };
        ClassTest ct = new ClassTest();
        // new int[]{} so sanh mang


        //Luan
        [Test]
        public void SapXepTang_Dung()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, ct.SapXepTang(arr));
        }
        [Test]
        public void SapXepTang_Sai()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3, 5, 4, 6, 7, 8, 9 }, ct.SapXepTang(arr));
        }

        [Test]
        public void SapXepGiam_Dung()
        {
            Assert.AreEqual(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, ct.SapXepGiam(arr));
        }

        [Test]
        public void SapXepGiam_Sai()
        {
            Assert.AreEqual(new int[] { 9, 7, 8, 6, 5, 4, 3, 2, 1, 0 }, ct.SapXepGiam(arr));
        }
        [Test]

        //Loc
        public void FinMax_Dung()
        {
            Assert.AreEqual(9, ct.FindMax(arr));
        }

        [Test]
        public void FinMax_Sai()
        {
            Assert.AreEqual(6, ct.FindMax(arr));
        }
        [Test]
        public void FinMin_Dung()
        {
            Assert.AreEqual(0, ct.FindMin(arr));
        }
        [Test]
        public void FinMin_Sai()
        {
            Assert.AreEqual(5, ct.FindMin(arr));
        }

        //Quynh
        [Test]
        public void TongChan_Dung()
        {
            Assert.AreEqual(20, ct.TongChan(arr));
        }
        [Test]
        public void TongChan_Sai()
        {
            Assert.AreEqual(21, ct.TongChan(arr));
        }
        [Test]
        public void Tongle_Dung()
        {
            Assert.AreEqual(25, ct.TongLe(arr));
        }
        [Test]
        public void Tongle_Sai()
        {
            Assert.AreEqual(26, ct.TongLe(arr));
        }
        [Test]
        public void Tong_Dung()
        {
            Assert.AreEqual(45, ct.Tong(arr));
        }
        [Test]
        public void Tong_Sai()
        {
            Assert.AreEqual(46, ct.Tong(arr));
        }


        //Khoi
        [Test]
        public void DemTongPT_Dung()
        {
            Assert.AreEqual(10, ct.DemTongPT(arr));
        }
        [Test]
        public void DemTongPT_Sai()
        {
            Assert.AreEqual(11, ct.DemTongPT(arr));
        }
        [Test]
        public void DemPTLe_Dung()
        {
            Assert.AreEqual(5, ct.DemLe(arr));
        }
        [Test]
        public void DemPTLe_Sai()
        {
            Assert.AreEqual(6, ct.DemLe(arr));
        }
        [Test]
        public void DemPTChan_Dung()
        {
            Assert.AreEqual(5, ct.DemChan(arr));
        }
        [Test]
        public void DemPTChan_Sai()
        {
            Assert.AreEqual(6, ct.DemChan(arr));
        }


        //Nguyen
        [Test]
        public void DemNguyenTo_Dung()
        {
            Assert.AreEqual(4, ct.DemNT(arr));
        }

        [Test]
        public void DemNguyenTo_Sai()
        {
            Assert.AreEqual(3, ct.DemNT(arr));
        }
        [Test]
        public void KTNT_Dung()
        {
            Assert.AreEqual(true, ct.KiemTraNguyenTo(2));
        }

        [Test]
        public void KTNT_Sai()
        {
            Assert.AreEqual(false, ct.KiemTraNguyenTo(2));
        }
        [Test]
        public void Vitri()
        {
            Assert.AreEqual(10, ct.ViTriDauTienX(arr, 9));
        }
        [Test]
        public void SoLanXuatHien_Foreach()
        {
            Assert.AreEqual(1, ct.SoLanXuatHien_Foreach(arr, 9));
        }
        [Test]
        public void SoLanXuatHien_For()
        {
            Assert.AreEqual(1, ct.SoLanXuatHien_For(arr, 9));
        }

        OPPCar opt = new OPPCar("Honda",1000,99999999,"Nguyen DInh Nguyen","Xe cua Nguyen");
        

        [Test]
        public void OOP_Name()
        {
            Assert.IsEmpty(opt.DungTich.ToString());
        }
        [Test]
        public void OOP_Thue()
        {
            Assert.AreEqual(4999999.9500000002, opt.tinhThue());
        }

        [Test]
        public void GiaiThuaDQ()
        {
            Assert.AreEqual(120, ct.GiaiThuaDQ(1000));
        }

        [Test]
        public void GiaiThuaBT()
        {
            Assert.AreEqual(120, ct.GiaiThuaBT(1000));
        }
    }
}