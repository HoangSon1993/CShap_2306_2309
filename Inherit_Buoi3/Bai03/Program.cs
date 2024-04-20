using System;
using System.Collections.Generic;

namespace Bai3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var l = new List<NhanVien>();

            l.Add(new NhanVien()
            {
                HoTen = "Nguyen Van An",
                LuongCoBan = 120000,
                SoNgayCong = 22,
                Tuoi = 18
            });
            l.Add(new TruongPhong()
            {
                HoTen = "Tran Thi Binh",
                LuongCoBan = 180000,
                SoNgayCong = 28,
                Tuoi = 26,
                PhuCapChucVu = 1000000
            });
            l.Add(new GiamDoc()
            {
                HoTen = "Tran Tiet Cuong",
                LuongCoBan = 220000,
                SoNgayCong = 24,
                Tuoi = 32,
                PhuCapChucVu = 2000000,
                ThamNien = 10
            });

            foreach (var item in l)
            {
                item.Xuat();
                Console.WriteLine();
            }

        }
    }
}