using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    public class SinhVien
    {
        public string hoTen;
        public int Tuoi;
        public double DiemLT;
        public double DiemTH;

        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {hoTen} - Tuổi: {Tuoi} - Điểm trung bình: {(DiemLT + DiemTH) / 2}");
        }

        public void Nhap()
        {
            Console.WriteLine("Vui lòng nhập thông tin sinh viên: ");
            Console.WriteLine("Họ tên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Tuổi");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Điểm lý thuyết");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Điểm thực hành");
            DiemTH = Convert.ToDouble(Console.ReadLine());
        }
    }
}
