using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class PhanSo
    {
        public int tuSo;
        public int mauSo;

        public PhanSo()
        {
            tuSo = 1;
            mauSo = 2;
        }

        public PhanSo(int a, int b)
        {
            tuSo = a;
            mauSo = b;
        }

        public void nhap()
        {
            Console.WriteLine("Nhập phân số: ");
            Console.Write("Tử số: ");
            tuSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mẫu số: ");
            mauSo= Convert.ToInt32(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine($"Phân số là: {tuSo}/{mauSo}");
        }

        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * p.mauSo + mauSo *p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            return kq.RutGon();
        }

        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo =tuSo *p.mauSo - mauSo *p.tuSo;
            kq.mauSo=mauSo *p.mauSo;

            return kq.RutGon();
        }

        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * p.tuSo;
            kq.mauSo= mauSo * p.mauSo;

            return kq.RutGon();
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo =tuSo * p.mauSo;
            kq.mauSo =mauSo * p.tuSo;

            return kq.RutGon();
        }

        public PhanSo RutGon()
        {
            int ucln = UCLN(tuSo, mauSo);
            tuSo /= ucln;
            mauSo /= ucln;
            return this;
        }

        public int UCLN(int a, int b)
        {
            if (a * b == 0)
            {
                return a + b;
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}
