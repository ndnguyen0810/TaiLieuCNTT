using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public class ClassTest
    {
        public Array SapXepTang(int[] arr)
        {
            int leg = arr.Length - 1;
            for (int i = 0; i < leg; i++)
            {
                for (int j = i + 1; j <= leg; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public Array SapXepGiam(int[] arr)
        {
            int l = arr.Length - 1;
            for (int i = 0; i < l; i++)
            {
                for (int j = i + 1; j <= l; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public int FindMax(int[] arr)
        {
            int[] sg = (int[])SapXepGiam(arr);
            int[] st = (int[])SapXepTang(arr); //lay sap xep tang
            return sg[0];//st[arr.lenght-1]
        }
        public int FindMin(int[] arr)
        {
            int[] s = (int[])SapXepTang(arr);
            return s[0];
        }
        public int TongChan(int[] s)
        {
            int sum = 0;
            foreach (var item in s)
                if (item % 2 == 0)
                    sum += item;
            return sum;
        }
        public int TongLe(int[] s)
        {
            int sum = 0;
            foreach (var item in s)
                if (item % 2 != 0)
                    sum += item;
            return sum;
        }
        public int Tong(int[] s)
        {
            int sum = 0;
            foreach (var item in s)
                sum += item;
            return sum;
        }
        public int DemTongPT(int[] s)
        {
            int dem = 0;
            foreach (var item in s)
                dem++;
            return dem;
        }
        
        public int DemChan(int[] s)
        {
            int dem = 0;
            foreach (var item in s)
                if (item % 2 == 0)
                    dem++;
            return dem;
        }
        public int DemLe(int[] s)
        {
            int dem = 0;
            foreach (var item in s)
                if (item % 2 != 0)
                    dem++;
            return dem;
        }

        public bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public int DemNT(int[] s)
        {
            int count = 0;
            foreach(var item in s)
            {
                if (KiemTraNguyenTo(item))
                {
                    count++;
                }
            }
            return count;
        }
        public Array ArrNT(int[] arr)
        {
            int[] nt = new int[arr.Length - 1];
            int n = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (KiemTraNguyenTo(arr[i])==true)
                {
                    nt[n] = arr[i];
                    n++;
                }
            }
            return nt;
        }
        
        
        public bool KT_ChinhPhuong(int a)
        {
            Boolean kq = false;
            double x = Math.Sqrt(a);
            if ((int)x * x == a) { kq = true; }
            return kq;

        }
        public Array ArrChinhPhuong(int[] arr)
        {
            int[] luu= arr;
            int x = 0;
            foreach(var item in arr)
            {
                if (KT_ChinhPhuong(item)==true)
                {
                    luu[x] = item;
                    x++;                  
                }
            }
            return luu;
        }

        public int ViTriDauTienX(int [] arr, int x)
        {
            int vt=0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == x)
                {
                    vt = i;
                    break;
                }
            }
            return vt+=1;
        }

        public int SoLanXuatHien_Foreach(int[] arr, int x)
        {
            int resual = 0;
            foreach(var item in arr)
            {
                if (item == x)
                {
                    resual++;                
                }
            }
            return resual;
        }
        public int SoLanXuatHien_For(int[] arr, int x)
        {
            int resual = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] == x)
                {
                    resual++;
                }
            }
            return resual;
        }

        public double GiaiThuaDQ(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * GiaiThuaDQ(n - 1);
            }
        }
        public double GiaiThuaBT(int n)
        {
            double kq = 1;
            for(int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }

    }

}
