using System;
using System.Runtime.Remoting.Channels;

namespace Bai3
{
    public class GiamDoc:TruongPhong
    {
        public int ThamNien { get; set; }
        public override double Luong => 30000000 + PhuCapChucVu + (ThamNien >= 10 ? 1000000 : 3000000);

        // public void Nhap()
        // {
        //     base.Nhap();
        //     Console.Write("Nhap tham nien: ");
        //     ThamNien = Convert.ToInt32(Console.ReadLine());
        // }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Tham nien: {ThamNien}");
        }
    }
}