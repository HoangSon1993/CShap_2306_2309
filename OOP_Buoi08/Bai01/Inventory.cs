using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Inventory
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public int Gold = 1000000000;

        public Inventory()
        {
            Items.Add(new Weapon()
            {
                Name = "Sword of Archangel",
                Price = 5000,
                Durability = 145,
                P_DMG_Min = 120,
                P_DMG_Max = 130,
                STR = 520,
                AGI = 200,
                Level = 80
            });
            Items.Add(new Potion()
            {
                Name = "HP Potions",
                Price = 100,
                HP = 10000,
                Quantity = 20
            });
            Items.Add(new Weapon()
            {
                Name = "Kundun Staff",
                Price = 4000,
                Durability = 255,
                P_DMG_Min = 80,
                P_DMG_Max = 100,
                STR = 128,
                AGI = 80,
                Level = 70
            });
            Items.Add(new Armor()
            {
                Name = "Titan Armor",
                Price = 27000,
                Durability = 170,
                P_DEF = 720,
                M_DEF = 150,
                STR = 500,
                END = 100,
                Level = 250
            });
            Items.Add(new Armor()
            {
                Name = "Dark Devil Armor",
                Price = 23000,
                Durability = 70,
                P_DEF = 200,
                M_DEF = 600,
                STR = 350,
                END = 180,
                Level = 200
            });
            Items.Add(new Shield()
            {
                Name = "Legendary Shield",
                Price = 1800,
                Durability = 255,
                P_DEF = 50,
                M_DEF = 50,
                STR = 100,
                END = 75,
                Level = 30
            });
            Items.Add(new Spellbook()
            {
                Name = "Book of Shadow",
                Price = 9999,
                Durability = 220,
                M_DMG_Min = 320,
                M_DMG_Max = 400,
                INT = 200,
                WIS = 200,
                Level = 180
            });
            Items.Add(new Weapon()
            {
                Name = "Dark Stinger Bow",
                Price = 4000,
                Durability = 0,
                P_DMG_Min = 100,
                P_DMG_Max = 125,
                STR = 200,
                AGI = 480,
                Level = 90
            });
        }

        public List<Item> ListAll() => Items.ToList();

        public List<Weapon> ListWeapon()
        {
            //var result = Items.Where(i => i is Weapon)
            //                  .OrderByDescending(i => (i as Weapon).P_DMG_Min)
            //                  .ThenBy(i => (i as Weapon).Crit_Chance)
            //                  .ToList();

            var result = Items.OfType<Weapon>()
                              .OrderByDescending(i => i.P_DMG_Min)
                              .ThenBy(i => i.Crit_Chance)
                              .ToList();
            return result;
        }

        // Dem so luong vat pham co trong inventory
        public int Count()
        {
            return Items.Count;
        }
        
        // Dem so vat pham theo moi loai

        public int Count(ItemType type)
        {
            return Items.Count(i => i.Type == type);
        }
        
        // Dem so vat pham bi hong

        public int CountBroken() => Items.Count(i => i.Durability < i.Durability_Max);
        
        // Tong so vang thu duoc khi ban tat ca vat pham

        public int TotalSellPrice() => Items.Sum(i => i.Price);
        
        // Tong so vang can thiet de sua chua cac vat pham: vd 1 dv sua chua = 1000 (gold)

        public int TotalRepairPrice() => Items.Sum(i => (i.Durability_Max - i.Durability) * 1000);
        
        // Nếu kho đồ có đủ tiền, sửa chữa tất cả vật phẩm trong kho (có trừ đi tiền sửa chữa).

        public bool RepairAll()
        {
            var totalRepairPrice = TotalRepairPrice();
            if (totalRepairPrice > Gold)
            {
                return false;
            }

            Gold -= totalRepairPrice;
            foreach (var item in Items)
            {
                item.Durability = item.Durability_Max;
            }

            return true;
        }
        
        // Cho biết vật phẩm yêu cầu chỉ số sức mạnh cao nhất.
        public List<Item> hightestRequireSTR()
        {
            var hightestSTR = Items.Max(i => i.STR);
            return Items
                .Where(i => i.STR == hightestSTR)
                .ToList();
        }
        
        // Tổng số máu có thể hồi được nếu dùng tất cả bình thuốc.

        public int TotalHPHealed()
        {
            return Items.Sum(i => (i as Potion).HP);
        }
        
        // Cho biết các chỉ số và cấp độ tối thiểu của nhân vật để có thể trang bị hết tất cả vật phẩm trong kho.
        // Cho biết top 3 vũ khí có sức tấn công tối đa cao nhất.
        public List<Weapon> Top3HighestDMGWeapons()
        {
            return Items.OfType<Weapon>()
                .OrderByDescending(i => i.P_DMG_Min)
                .Take(3)
                .ToList();
        }
        // Cho biết top 3 khiên có kháng sát thương phép thuật thấp nhất.
        public List<Shield> Top3LowestDEFShields()
        {
            return Items.OfType<Shield>()
                .OrderBy(i => i.M_DEF)
                .Take(3)
                .ToList();
        }
    }
}
