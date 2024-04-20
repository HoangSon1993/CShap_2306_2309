using System;

namespace Bai3
{
    public class TruongPhong:NhanVien
    {
        public double PhuCapChucVu { get; set; }
        public override double Luong => (SoNgayCong * LuongCoBan) + PhuCapChucVu;

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Phu cap chuc vu: {PhuCapChucVu}");
        }
    }
}