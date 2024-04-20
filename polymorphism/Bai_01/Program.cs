using System.Collections.Generic;
using Bai_01.Properties;

namespace Bai_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<DongVat> ls = new List<DongVat>();
            ls.Add(new Cho());
            ls.Add(new Meo());
            ls.Add(new Cho());

            foreach (var item in ls)
            {
                item.Keu();
            }
        }
    }
}