using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami.Core.Data
{
    public class Yonetici : IPersonel
    {
        public string AdSoyad { get; set; }

        private int _calismaSaati;
        public int CalismaSaati 
        { get
            {
                return _calismaSaati;
            } 
            set
            {
                if (value<0)
                {
                    throw new Exception("Çalışma saati 0 dan küçük olamaz!");
                }
                _calismaSaati = value;
            }
        }

        private decimal _saatlikUcret;
        public decimal SaatlikUcret 
        { 
            get
            {
                return _saatlikUcret;
            }
            set
            {
                if (value<500)
                {
                    throw new Exception("Saatlik ücret 500 den küçük olamaz!");
                }
                _saatlikUcret = value;
            }
        }

        private decimal _bonus;
        public decimal Bonus 
        { 
            get
            {
                return _bonus;
            } 
            set
            {
                if (value<0)
                {
                    throw new Exception("Bonus 0 dan küçük olamaz!");
                }
                _bonus = value;
            } 
        }

        public decimal MaasHesapla()
        {
            return CalismaSaati * SaatlikUcret + Bonus;
        }
    }
}
