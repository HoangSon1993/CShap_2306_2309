using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Potion : Item
    {
        public int HP { get; set; }

        public int Mana { get; set; }

        public int Quantity { get; set; }

        public override int STR => 0;

        public override int AGI => 0;

        public override int INT => 0;

        public override int WIS => 0;

        public override int END => 0;

        public override int Level => 0;

        public Potion()
        {
            Type = ItemType.Potion;
        }
    }
}
