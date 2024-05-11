using System;
using System.Net;
using LyHoangSon_02.Models;

namespace LyHoangSon_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Farm myFarm = new Farm();
     
            //Tổng lượng sữa của trang trại (gồm sữa của bò và sữa tồn kho).
            var totalMilk = myFarm.TotalMeatInFarm();
            Console.WriteLine($"Tổng lượng sữa của trang trại: {totalMilk} (l)");
            
            //Liệt kê động vật cho nhiều trứng nhất.
            Console.WriteLine("Danh sách động vật có nhiều trứng nhất");
            var listMaxAge = myFarm.Animal_Max_Egg();
            foreach (var chicken in listMaxAge)
            {
                Console.WriteLine(chicken);
            }
            
            //Liệt kê tất cả động vật thuộc giống Tây Tạng.
            Console.WriteLine("Danh sách động vật giống Tây Tạng");
            var List_TayTang = myFarm.List_TayTang();
            foreach (var animal in List_TayTang)
            {
                Console.WriteLine(animal);
            }
            
            //Cho biết tổng lượng thịt mà cả trang trại chung cấp. Biết rằng Bò, Heo, Gà lần
            // lượt cung cấp 80%, 60%, 75% cân nặng của nó thành thịt.
            var max_agge = myFarm.Animal_Max_Egg();
            foreach (var a in max_agge)
            {
                Console.WriteLine(a);
            }

            var totalMeat = myFarm.TotalMeatInFarm();
            Console.WriteLine($"Tổng lượng thịt có trong farm: {totalMeat} (kg)");
        }
    }
}