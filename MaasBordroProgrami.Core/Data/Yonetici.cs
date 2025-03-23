
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
        public string Kadro { get; set; } = "Yönetici"; //Varsayılan olarak atandı. 

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

        public decimal SaatlikUcret => 600;  //Saatlik ücreti 600 olarak sabitler (get var set yok)

        public decimal Bonus => 10000; //(Get var set yok) read-only bir özellik

        public string Derece //Memur için derece özelliği eklediğim ve tablolarda kullanmak istediğim için burada boş bir değer döndürdüm.
        {
            get { return "-"; }
            set { } //Atanma IPersonelden dolayı olmak zorunda ama atanma olsa bile return hep "-" olur.
        }


        public decimal MaasHesapla()
        {
            return (CalismaSaati * SaatlikUcret);
        }

        public decimal MesaiHesapla()
        {
            return Bonus;
        }
    }
}
