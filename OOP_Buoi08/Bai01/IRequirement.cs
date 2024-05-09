using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal interface IRequirement
    {
        int STR { get; set; }  // Vat ly

        int AGI { get; set; } //

        int INT { get; set; } // Thong minh

        int WIS { get; set; } //

        int END { get; set; } 

        int Level { get; set; } // Cap do
    }
}
