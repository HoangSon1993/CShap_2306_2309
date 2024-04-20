using System;

namespace Inherit_Buoi3
{
    public class HinhChuNhat
    {
        public double A { get; set; }
        public double B { get; set; }

        public double ChuVi => (A + B) * 2;
        public double DienTich => A * B;

        public void Nhap()
        {
            Console.Write("Nhap chieu dai:");
            A = Convert.ToDouble(Console.ReadKey());
            Console.Write("Nhap chieu rong: ");
            B = Convert.ToDouble(Console.ReadKey());
        }

        public void Xuat()
        {
            Console.WriteLine($"Do dai 2 canh {A}, {B}");
            Console.Write($"Chu vi: {ChuVi}");
            Console.WriteLine($"Dien tich: {DienTich}");
            
        }
    }
}