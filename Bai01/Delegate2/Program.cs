using System;
using System.Net.Sockets;

namespace Delegate2
{
    internal class Program
    {
        // Khai báo 1 delegate có signature là (int, int) => int
        delegate int PerformCaculation(int x, int y);

        public static void Main(string[] args)
        {
            Caculator c = new Caculator();
            
            // 3. Gán phương thức vào delegate
            c.Calculate = Add;
            
            // 4. Thực thi (invoke) delegate
            int result = c.Calculate(3, 5); // ==> nếu biến delegate là null, trình biên dịch báo lỗi.
            // hoặc cách 2
          //  result = c.Calculate.Invoke(3, 5);  // ==> nếu biến delegate đang là null, trình biên dịch sẽ bỏ qua, không thực thi và không báo lỗi

            Console.WriteLine(result);

          c.Calculate = Power;
          int result2 = c.Calculate(2, 3);
          Console.WriteLine(result2);

          c.Calculate = Sigma;
          Console.WriteLine(c.Calculate(1,2));

        }

        static int Add(int x, int y) => x + y;
        static int Power(int x, int y) => Convert.ToInt32(Math.Pow(x, y));

        static int Sigma(int x, int y)
        {
            int result = 0;
            for (int i = x; i <= y; i++)
            {
                result += i;
            }

            return result;
        }
    }

    internal class Caculator
    {
        // 1. Khai báo (declare) kiểu delegate
        public delegate int PerformCaculation(int x, int y);
        
        // 2. Khởi tạo (instantiate) biến delegate
        public PerformCaculation Calculate { get; set; }  // ==> Calculate là 1 biến delegate, không phải là object
    }
}


