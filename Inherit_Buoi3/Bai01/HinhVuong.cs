using System;

namespace Inherit_Buoi3
{
    public class HinhVuong:HinhChuNhat
    {
        public void Nhap()
        {
            Console.Write("Nhap canh: ");
            A = Convert.ToDouble(Console.ReadKey());
            B = A;
        }
    }
}