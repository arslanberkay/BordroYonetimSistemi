using MaasBordroProgrami.Core.Enums;
using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Data
{
    public class Yonetici : IPersonel
    {
        public string AdSoyad { get; set; }
        public string Kadro { get; set; } = "Yönetici";

        private int _calismaSaati;
        public int CalismaSaati
        {
            get
            {
                return _calismaSaati;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Çalışma saati 0 dan küçük olamaz!");
                }
                _calismaSaati = value;
            }
        }

        public decimal SaatlikUcret => 600;

        public decimal Bonus => 1000;

        public string Derece
        {
            get { return "-"; }
            set { }

        }

        public decimal MaasHesapla()
        {
            return (CalismaSaati * SaatlikUcret)  ;
        }

        public decimal MesaiHesapla()
        {
            return Bonus;
        }
    }
}
