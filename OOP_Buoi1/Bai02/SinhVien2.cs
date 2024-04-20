using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class SinhVien2
    {
        public string Ho { get; set; }
        public string Ten { get; set; }
        public double DiemLT { get; set; }
        public double DiemTH { get; set; }
        public string HoTen => $"{Ho} {Ten}";  //Expression Body
        public double DiemTB => (DiemLT + DiemTH) / 2;
        public bool Dau => DiemTH <= 5;
    }
}
