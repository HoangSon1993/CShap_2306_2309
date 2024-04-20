using System;
using System.Diagnostics.SymbolStore;

namespace Bai03
{
    public class Triangle
    {
        public Point A { get; set; } = new Point();
        public Point B { get; set; } = new Point();
        public Point C { get; set; } = new Point();

        public double AB => A.DistanceTo(B);
        public double BC => B.DistanceTo(C);
        public double CA => C.DistanceTo(A);

        public double Perimeter => AB + BC + CA;

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
            }
        }

        public bool IsRight => AB * AB == BC * BC + CA * CA || 
                               BC * BC == AB * AB + CA * CA ||
                               CA * CA == AB * AB + BC * BC;

        public void Output()
        {
            Console.WriteLine("Toạ độ 3 đỉnh tam giác:");
            A.Output();
            Console.Write(",");
            B.Output();
            Console.Write(",");
            C.Output();
            Console.WriteLine();
            Console.WriteLine($"Chu vi tam giac: {Perimeter}");
            Console.WriteLine($"Dien tich tam giac: {Area}");
            Console.WriteLine($"Tam giac{(IsRight?"":"khong")} vuong");
            
        }

        public void Input()
        {
            A.Input();
            B.Input();
            C.Input();
            
        }
    }
}