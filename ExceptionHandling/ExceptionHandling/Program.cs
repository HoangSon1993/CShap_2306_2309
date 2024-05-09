using System;

namespace ExceptionHandling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("Nhap vao 1 so nguyen A: ");
           string input = "8";
            try
            {
                //int a = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(input);
                if (a == 8)
                {
                    throw new ArgumentException();
                }

                if (a == 6)
                {
                    throw new LoiGiDoException("Loi gi day");
                }

                if (a % 2 == 0)
                {
                    Console.WriteLine("A là số chẵn.");
                }
                else
                {
                    Console.WriteLine("A là số lẻ.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị không thể chuyển đổi số nguyên. Vui lòng nhập lại");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Giá trị vượt quá khoảng dữ liệu Int32. Vui lòng nhập lại");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Bạn đã nhập số 8. Vui lòng nhập lại.");
            }
            catch (LoiGiDoException e)
            {
                Console.WriteLine($"LoiGiDoException {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            
            // ===== ví dụ 2 =====
            // try
            // {
            //     Console.WriteLine("Nhap vao so nguyen a:");
            //     int a = Convert.ToInt32(Console.ReadLine());
            //
            //     Console.WriteLine("Nhap vao so nguyen b:");
            //     int b = Convert.ToInt32(Console.ReadLine());
            //
            //     var c = PhepChia(a, b);
            //     Console.WriteLine($"Ket qua phep chia: {c}");
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("Giá trị không thể chuyển đổi số nguyên. Vui lòng nhập lại");
            // }
            // catch (OverflowException)
            // {
            //     Console.WriteLine("Giá trị vượt quá khoảng dữ liệu Int32. Vui lòng nhập lại");
            // }
            // catch (ArgumentException)
            // {
            //     Console.WriteLine("Bạn đã nhập số 8. Vui lòng nhập lại.");
            // }
            // catch (DivideByZeroException)
            //
            // {
            //     Console.WriteLine("DivideByZeroExec bene ngoai");
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Loi khong xac dinh");
            // }
        }

        /// <summary>
        /// Mo ta ham: Ham dung de tinh thuong 2 so thuc
        /// </summary>
        /// <param name="a">So chia</param>
        /// <param name="b">So bi chia</param>
        /// <returns>Thuong cua so chia va so bi chia</returns>
        /// <exception cref="DivideByZeroException"></exception>
        private static object PhepChia(int a, int b)
        {
            //     if (b == 0)
            //     {
            //         throw new DivideByZeroException();
            //     }
            var c = 0;
            // try
            // {
            c = a / b;
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Khong the chia cho 0");
            //     throw new DivideByZeroException();
            // }

            return c;
        }
    }

    class LoiGiDoException : Exception
    {
        public LoiGiDoException(string message) : base(message)
        {
        }
    }
}