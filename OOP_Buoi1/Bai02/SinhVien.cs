using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class SinhVien
    {
        //Field/ Atribute --> camelCase hoặc '_'
        private double diemLT = 5.5;

        //property
        public double DiemLT //Pascal Case
        {
            get { return diemLT; } //phuong thuc
            set
            {
                if (value < 0) { }
                diemLT = value;
            } //phuoc thuc
        }

        //public double GetDiemLT()
        //{
        //    return DiemLT;
        //}

        //public void SetDiemLT(double x)
        //{
        //    DiemLT = x;
        //}


    }
}
