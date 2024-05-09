using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Weapon : Item
    {
        public int P_DMG_Min { get; set; } // Sat thuong vat ly toi thieu

        public int P_DMG_Max { get; set; } // Sat thuong vat ly toi da

        public int Crit_Chance { get; set; } // Ty le chi mang

        public override int INT => 0;

        public override int WIS => 0;

        public override int END => 0;

        public Weapon()
        {
            Type = ItemType.Weapon;
        }
    }
}
