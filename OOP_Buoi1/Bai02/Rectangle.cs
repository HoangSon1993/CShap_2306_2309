using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Perimeter => (Height + Width) * 2;
        public double Area => Height * Width;

        public void Input()
        {
            Console.Write("Input Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Width: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: { Height}");
            Console.WriteLine($"Perimeter: {Perimeter}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
