using MaasBordroProgrami.Core.Enums;
using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Data
{
    public class Memur : IPersonel
    {
        public string AdSoyad { get; set; }
        public string Kadro { get; set; } = "Memur";

        private int ekMesaiSaati;
        public string Derece { get; set; } = "Düz Memur";

        private int _calismaSaati;
        public int CalismaSaati
        {
            get
            {
                return _calismaSaati+ekMesaiSaati;
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
                return Derece switch
                {
                    "Baş Memur" => 650,
                    "Uzman Memur" => 600,
                    "Kıdemli Memur" => 550,
                    "Düz Memur" => 500,

                };
            }
        }



        public decimal MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati) + (ekMesaiSaati * SaatlikUcret * 1.5m);
        }
    }
}
