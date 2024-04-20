using System;

namespace Bai03
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void Input()
        {
            Console.WriteLine("Nhap toa do: ");
            Console.Write("X= ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        public void Output() => Console.Write($"({X}, {Y})");
        public double DistanceTo(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
    }
}