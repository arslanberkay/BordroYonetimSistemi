
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
        public string Kadro { get; set; } = "Memur"; //Varsayılan olarak değer atadım.

        private int ekMesaiSaati;
        public string Derece { get; set; } = "Düz Memur"; //Eğer seçilmezse varsayılan olarak Düz Memur olur.

        private int _calismaSaati;
        public int CalismaSaati //Çalışma saatini ve ek mesai süresini hesaplar.
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
            {   //Memurun Derecesine göre saatlik ücretini döndürür.
                return Derece switch  //switch expression kullandım.
                {
                    "Baş Memur" => 575,
                    "Uzman Memur" => 550,
                    "Kıdemli Memur" => 525,
                    "Düz Memur" => 500,
                };
            }
        }

        public decimal MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati - ekMesaiSaati);
        }

        public decimal MesaiHesapla()
        {
            return (ekMesaiSaati * (SaatlikUcret * 3 / 2));
        }
    }
}
