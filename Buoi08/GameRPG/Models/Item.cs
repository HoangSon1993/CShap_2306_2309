namespace GameGPG.Models
{
    public class Item:IRequirement // Vat Pham
    {
        public virtual int STR { get; set; }
        public virtual int AGI { get; set; }
        public virtual int INT { get; set; }
        public virtual int WIS { get; set; }
        public virtual int END { get; set; }
        public virtual int Level { get; set; }

        public string Id { get; set; } // Ma so
        public string Name { get; set; } // Ten
        public int Price { get; set; } //Gia tien
        public int Durability { get; set; } // Do ben hien tai
        public int Durability_Max { get; set; } = 255; // Do ben toi da
    }
}