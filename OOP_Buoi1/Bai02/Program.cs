using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Để màn hình console hiển thị Tiếng Việt với bảng mã UTF-8

            //var a = new PhanSo();
            //a.nhap();
            //var b = new PhanSo();
            //b.nhap();

            //a.Cong(b).xuat();



            //SinhVien sv = new SinhVien();
            //sv.DiemLT = 10;
            //Console.WriteLine(sv.DiemLT);


            //SinhVien2 sv2 = new SinhVien2()
            //// cú pháp của Object Initializer
            //{
            //    Ho = "Ly Hoang",
            //    Ten = "Son",
            //    DiemLT = 5.5,
            //    DiemTH = 6.6
            //};
            //Console.WriteLine($"Diem Tb: {sv2.DiemTB}, ket qua: {sv2.Dau}");

            Rectangle hcn = new Rectangle();
            hcn.Input();
            hcn.Output();
        }

    }
}
