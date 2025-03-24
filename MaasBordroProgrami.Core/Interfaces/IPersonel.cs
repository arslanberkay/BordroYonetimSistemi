using MaasBordroProgrami.Core.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Interfaces
{
    public interface IPersonel
    {
        public string AdSoyad { get; set; }
        public string Kadro { get; set; }
        public string Derece { get; set; }
        public int CalismaSaati { get; set; }
        public decimal SaatlikUcret { get; }
        

        public decimal MaasHesapla();
        public decimal MesaiHesapla();

    }
}
