using System.Collections.Generic;
using System.Linq;

namespace LyHoangSon_02.Models
{
    public class Farm
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public int TotalEgg { get; set; }
        public int TotalMilk { get; set; }

        public Farm()
        {
           Animals.Add(new Chicken()
           {
               Id = 1,
               Name = "Gà Tre",
               Weight = 0.850,
               Gender = E_Gender.Female,
               SanLuongTrungGa = 24
           });
           Animals.Add(new Chicken()
           {
               Id = 2,
               Name = "Gà Ri",
               Weight = 0.550,
               Gender = E_Gender.Female,
               SanLuongTrungGa = 18
           });
           Animals.Add(new Chicken()
           {
               Id = 3,
               Name = "Gà Ác",
               Weight = 0.620,
               Gender = E_Gender.Female,
               SanLuongTrungGa = 24
           });
           
           
           
           
           Animals.Add(new Pig()
           {
              Id = 4,
              Name = "Lợn Móng Cái",
              Gender = E_Gender.Male,
              Weight = 120
           });
           Animals.Add(new Pig()
           {
              Id = 5,
              Name = "Lợn Ỉ",
              Gender = E_Gender.Male,
              Weight = 180
           });
           Animals.Add(new Pig()
           {
              Id = 6,
              Name = "Lợn Sóc",
              Gender = E_Gender.Male,
              Weight = 95
           });
           
           
           
           Animals.Add(new Cow()
           {
               Id = 7,
               Name = "Ayrshire",
               Gender=E_Gender.Female,
               Weight = 550,
               SanLuongSua = 7500
           });
           Animals.Add(new Cow()
           {
               Id = 8,
               Name = "Guernsey",
               Gender=E_Gender.Female,
               Weight = 650,
               SanLuongSua = 6500
           });
           Animals.Add(new Cow()
           {
               Id = 9,
               Name = "Jersey",
               Gender=E_Gender.Female,
               Weight = 500,
               SanLuongSua = 7000
           });
        }

        // Tổng lượng sữa của trang trại (gồm sữa của bò và sữa tồn kho).
        public int TotalMilkInFarm()
        {
            var rs = Animals.OfType<Cow>().Sum(a=>a.SanLuongSua);
            return rs;

        }
        
        // Liệt kê động vật cho nhiều trứng nhất.
        public List<Chicken> Animal_Max_Egg()
        {
            var maxEgg = Animals.OfType<Chicken>().Max(c => c.SanLuongTrungGa);
            return Animals.OfType<Chicken>().Where(c => c.SanLuongTrungGa == maxEgg).ToList();
        }
        // Liệt kê tất cả động vật thuộc giống Tây Tạng.

        public List<Animal> List_TayTang()
        {
            var rs = new List<Animal>();
            rs = Animals.Where(a => a.Name.Contains("Tây Tạng")).ToList();
            return rs;
        }
        // Cho biết tổng lượng thịt mà cả trang trại chung cấp. Biết rằng Bò, Heo, Gà lần
        // lượt cung cấp 80%, 60%, 75% cân nặng của nó thành thịt.

        public double TotalMeatInFarm()
        {
            // var total_Pig = Animals.OfType<Pig>().Sum(c=>c.Weight) * 80/100;
            // var total_Cow = Animals.OfType<Cow>().Sum(c=>c.Weight) * 60/100;;
            // var total_Chicken = Animals.OfType<Chicken>().Sum(c=>c.Weight) * 75/100;
            // return total_Chicken + total_Cow + total_Pig;

            
            double totalMeat = 0;
            foreach (var _animal in Animals)
            {
                if (_animal is Pig)
                {
                    totalMeat += _animal.Weight * 80 / 100;
                }
                if (_animal is Cow)
                {
                    totalMeat += _animal.Weight * 60 / 100;
                }
                if (_animal is Chicken)
                {
                    totalMeat += _animal.Weight * 75 / 100;
                }
            }
            
            return totalMeat;
        }
        
    }
}