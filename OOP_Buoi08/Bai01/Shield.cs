using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Shield : Item
    {
        public int P_DEF { get; set; }

        public int M_DEF { get; set; }

        public override int AGI => 0;

        public override int INT => 0;

        public override int WIS => 0;

        public Shield()
        {
            Type = ItemType.Shield;
        }
    }
}
