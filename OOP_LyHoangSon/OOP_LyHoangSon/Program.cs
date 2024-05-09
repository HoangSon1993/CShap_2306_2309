using System;
using OOP_LyHoangSon.Models;

namespace OOP_LyHoangSon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            var rs = inventory.Devices;

            foreach (var item in rs)
            {
                Console.WriteLine(item);
            }
        }
    }
}