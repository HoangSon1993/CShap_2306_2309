using System;
using System.Runtime.InteropServices;

namespace Buoi6_Abstract.Properties
{
    public class HinhChuNhat:IHinhHoc
    {
        public virtual double A { get; set; }
        public virtual double B { get; set; }
        public virtual void Xuat()
        {
            Console.WriteLine("===== THÔNG TIN HÌNH CHỮ NHẬT =====");
            Console.WriteLine($"Độ dài 2 canh: {A}, {B}");
            Console.WriteLine($"Chu vi: {ChuVi()}");
            Console.WriteLine($"Diện tích: {DienTich()}");
            
        }

        public double ChuVi() => (A + B) * 2;

        public double DienTich() => A * B;
    }
}