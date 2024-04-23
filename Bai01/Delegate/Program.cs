using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> l = new List<int>() { -3, 2, 8, -4, 6 };
            //Console.WriteLine(TinhTong(l, x => x % 3 == 0));
            var list = TimKiem(l, x => x > 0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static int TinhTong(List<int> l, Predicate<int> p)
        {
            int tong = 0;
            foreach (var item in l)
            {
                if (p(item))
                {
                    tong += item;
                }
            }

            return tong;
        }
        static List<int> TimKiem(List<int> l, Predicate<int> p)
        {
            List<int> kq = new List<int>();
            foreach (var item in l)
            {
                if (p(item))
                {
                    kq.Add(item);
                }
            }
            return kq;
        }
    }
}