using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Data
{
    public class MaasBordro
    {
        public string PersonelIsmi { get; set; }
        public string Kadro { get; set; }
        public int CalismaSaati { get; set; }
        public decimal AnaOdeme { get; set; }
        public decimal MesaiUcreti { get; set; }
        public decimal ToplamOdeme { get; set; }
    }
}
