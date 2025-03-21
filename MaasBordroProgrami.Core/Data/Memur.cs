using MaasBordroProgrami.Core.Enums;
using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Data
{
    public class Memur : IPersonel
    {
        public string AdSoyad { get; set; }

        private int ekMesaiSaati;
        public MemurDerecesi MemurDerecesi { get; set; }

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
                    throw new Exception("Çalışma süresi negatif olamaz!");
                }
                else if (value > 180)
                {
                    _calismaSaati = 180;
                    ekMesaiSaati = value - 180;
                }
                else
                {
                    _calismaSaati = value;
                    ekMesaiSaati = 0; //Ek mesai yoksa sıfır olarak alınsın.
                }
            }
        }

        private decimal _saatlikUcret;
        public decimal SaatlikUcret
        {
            get
            {
                return MemurDerecesi switch
                {
                    MemurDerecesi.BasMemur => 700,
                    MemurDerecesi.UzmanMemur => 650,
                    MemurDerecesi.KidemliMemur => 600,
                    MemurDerecesi.Memur => 550,
                    MemurDerecesi.YeniMemur => 500
                };
            }


        }

        public decimal MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati) + (ekMesaiSaati * SaatlikUcret * 1.5m);
        }
    }
}
