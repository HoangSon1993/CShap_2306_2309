using System;

namespace Buoi6_Abstract.Properties
{
    public class HinhElip:IHinhHoc
    {
        public virtual double R1 { get; set; }
        public virtual double R2 { get; set; }
        public virtual void Xuat()
        {
            Console.WriteLine("===== THÔNG TIN HÌNH ELIP =====");
            Console.WriteLine($"Bán kinh: {R1}, {R2}");
            Console.WriteLine($"Chu vi: {ChuVi()}");
            Console.WriteLine($"Diện tích: {DienTich()}");
        }

        public double ChuVi() => 2 * Math.PI * Math.Sqrt((R1 * R1 + R2 * R2) / 2);

        public double DienTich() => Math.PI * R1 * R2;
    }
}