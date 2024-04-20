using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Để màn hình console hiển thị Tiếng Việt với bảng mã UTF-8

            /*
            int a;
            Console.WriteLine("Nhập số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Giá trị của a là: " + a);
            //var z;   // Lỗi ngầm định

            //-------------------------
            string s = "hello world";
            //Chuỗi cần ghi: I am "hero"
            // C:\ABC
            string s1 = "I am \"hero\"";
            string s2 = "C:\\ABC";
            s2 = @"C:\ABC";

            //Nối chuỗi
            string ss1 = "Hello";
            string ss2 = "World";
            string ss3 = ss1 + ss2;
            */

            /*
            // Bài 2:
            Console.WriteLine("Nhập số nguyên có 3 chữ số: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int a = x / 100;
            int b = x / 10 % 10;
            int c = x % 10;
            Console.WriteLine("Tổng 3 số nguyên là: " + (a + b + c));
            */

            /*
            //Bài 4: Nhập vào 1 số nguyên dương cho biết đó có phải là số nguyên tố hay không
            Console.WriteLine("Nhập vào 1 số nguyên dương: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool kq = true;

            if (x <= 1)
            {
                kq = false;
            }

            if (x == 2 || x == 3)
            {
                kq = true;
            }
            else
            {
                for (int i = 2; i <= x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        kq = false;
                        break;
                    }
                }
            }

            if (kq == true)
            {
                Console.WriteLine($"{x} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{x} không là số nguyên tố");
            }
            */

            /*
            var sv = new SinhVien();
            sv.Nhap();
            sv.Xuat();
            */

        }
    }

}
