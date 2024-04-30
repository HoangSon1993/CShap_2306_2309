using System;

namespace BT_Linq
{
    public class Book
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        

        public override string ToString()
        {
            return ($"ID: {Id} - Sku: {Sku} - Name: {Name} - Author: {Author} - Price: {Price} - Stock: {Stock}");
        }
    }

    
}