using System;
using System.Runtime.InteropServices;

namespace Demo_exception
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            double kq = 0;


            try
            {
                nhap_A(out a);
                nhap_B(out b);
                PhepChia2So(a, b, out kq);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Lỗi không đúng định dạng");
                Console.WriteLine($"Thong bao loi di kem la: {e.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lỗi tràn số");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Lỗi chia cho 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi chưa xác định");
            }
            finally
            {
                Console.WriteLine("Day la finally");
            }

            Console.WriteLine($"So thu nhat la: {a}");
            Console.WriteLine($"So thu hai la: {b}");
            Console.WriteLine($"ket qua phep chia: {kq}");
        }

        public static void PhepChia2So(int a, int b, out double kq)
        {
            kq = a / b;
        }

        public static void nhap_A(out int a)
        {
            Console.Write("Nhập số a: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                throw new FormatException("So A vừa nhập không đúng định dạng");
            }
        }

        public static void nhap_B(out int b)
        {
            Console.Write("Nhập số b: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
               
                throw new FormatException("So B vua nhap khong dung dinh dang");
            }
        }
    }
}