using System;

namespace Bai3
{
    public class NhanVien
    {
        public String HoTen { get; set; }
        public int Tuoi { get; set; }
        public int SoNgayCong { get; set; }
        public double LuongCoBan { get; set; }

        public virtual double Luong => SoNgayCong * LuongCoBan;

        // public void Nhap()
        // {
        //     Console.WriteLine("Nhap Thong Tin Nhan Vien: ");
        //     Console.Write("Ho Ten: ");
        //     HoTen = Convert.ToString(Console.ReadLine());
        //     Console.Write("Tuoi: ");
        //     Tuoi = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("So ngay cong: ");
        //     SoNgayCong = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Luong co ban: ");
        //     LuongCoBan = Convert.ToDouble(Console.ReadLine());
        // }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ho Ten: {HoTen}");
            Console.WriteLine($"Tuoi: {Tuoi}");
            Console.WriteLine($"Luong co ban: {LuongCoBan}");
            Console.WriteLine($"Luong: {Luong}");
        }
    }
}