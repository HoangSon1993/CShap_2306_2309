using System;

namespace Buoi6_Abstract.Properties
{
    public class HinhVuong:HinhChuNhat
    {
        public override double A { get=>B; }

        public override void Xuat()
        {
            Console.WriteLine("===== THÔNG TIN HÌNH VUÔNG =====");
            Console.WriteLine($"Chiều dài cạnh: {A}");
            Console.WriteLine($"Chu vi: {ChuVi()}");
            Console.WriteLine($"Diện tích: {DienTich()}");
        }
    }
}