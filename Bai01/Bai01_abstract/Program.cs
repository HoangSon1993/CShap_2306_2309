using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Buoi6_Abstract.Properties;

namespace Buoi6_Abstract
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Tạo một đối tượng Stopwatch để đo thời gian
            Stopwatch stopwatch = new Stopwatch();

            // Bắt đầu đo thời gian
            stopwatch.Start();
            
            Console.OutputEncoding = Encoding.UTF8;

            List<IHinhHoc> ds = new List<IHinhHoc>();
            ds.Add(new HinhVuong(){A=3,B=3});
            ds.Add(new HinhTron(){R1 = 2,R2 = 2});
            ds.Add(new HinhVuong(){A=5,B = 5});
            ds.Add(new HinhChuNhat(){A = 8,B = 6});
            ds.Add(new HinhElip(){R1 = 5,R2 = 2});

            foreach (var item in ds)
            {
                item.Xuat();
                Console.WriteLine();
            }

            // Dừng đo thời gian
            stopwatch.Stop();

            // Lấy thời gian đã chạy
            TimeSpan elapsedTime = stopwatch.Elapsed;

            // In ra thời gian đã chạy
            Console.WriteLine("Total time elapsed: " + elapsedTime);
        }
    }
}