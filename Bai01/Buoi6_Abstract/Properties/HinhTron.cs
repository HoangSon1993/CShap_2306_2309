using System;

namespace Buoi6_Abstract.Properties
{
    public class HinhTron:HinhElip
    {
        public override double R1
        {
            get => R2;
        }

        public override void Xuat()
        {
            Console.WriteLine("===== THÔNG TIN HÌNH TRÒN =====");
            Console.WriteLine($"Bán kinh: {R1}");
            Console.WriteLine($"Chu vi: {ChuVi()}");
            Console.WriteLine($"Diện tích: {DienTich()}");
        }
    }
}