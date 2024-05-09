using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Spellbook : Item
    {
        public int M_DMG_Min { get; set; }

        public int M_DMG_Max { get; set; }

        public override int STR => 0;

        public override int AGI => 0;

        public override int END => 0;

        public Spellbook()
        {
            Type = ItemType.Spellbook;
        }
    }
}
