using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Item : IRequirement
    {
        public virtual int STR { get; set; }

        public virtual int AGI { get; set; }

        public virtual int INT { get; set; }

        public virtual int WIS { get; set; }

        public virtual int END { get; set; }

        public virtual int Level { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Durability { get; set; }

        public int Durability_Max { get; set; } = 255;

        public ItemType Type { get; set; }

        public override string ToString() => $"{Name} - Price: {Price} - Durability: {Durability} - STR: {STR} - AGI: {AGI} - INT: {INT} - WIS: {WIS} - END: {END} - Level: {Level}";
    }

    public enum ItemType
    {
        Weapon,
        Potion,
        Shield,
        Armor,
        Spellbook
    }
}
