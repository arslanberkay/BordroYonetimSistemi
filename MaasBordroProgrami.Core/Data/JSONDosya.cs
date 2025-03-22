using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace MaasBordroProgrami.Core.Data
{
    public class JSONDosya
    {
        public static BindingList<IPersonel> PersonelListesiOku()
        {
            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "Data");
            string jsonDosyaYolu = Path.Combine(hedefDizin, "data.json");

            if (!File.Exists(jsonDosyaYolu))
            {
                throw new Exception("JSON dosyası bulunamadı.");
            }

            string jsonVeri = File.ReadAllText(jsonDosyaYolu);
            var hamListe = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonVeri);

            var personelListesi = new BindingList<IPersonel>();

            foreach (var item in hamListe)
            {
                if (item.ContainsKey("Kadro") && item["Kadro"].ToString() == "Yönetici")
                {
                    var yonetici = JsonConvert.DeserializeObject<Yonetici>(JsonConvert.SerializeObject(item));
                    personelListesi.Add(yonetici);
                }
                else if (item.ContainsKey("Kadro") && item["Kadro"].ToString() == "Memur")
                {
                    var memur = JsonConvert.DeserializeObject<Memur>(JsonConvert.SerializeObject(item));
                    personelListesi.Add(memur);
                }
            }
            return personelListesi;
        }

        public static void PersonelListesineKaydet(List<IPersonel> personelListesi)
        {

            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "Data");
            string jsonDosyaYolu = Path.Combine(hedefDizin, "data.json");

            var jsonList = new List<object>();

            foreach (var personel in personelListesi)
            {
                jsonList.Add(new
                {
                    personel.AdSoyad,
                    personel.CalismaSaati,
                    personel.Kadro,
                    personel.Derece
                });
            }

            string jsonVeri = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
            File.WriteAllText(jsonDosyaYolu, jsonVeri);

        }

        public static void PersonelAdinaKaydet(MaasBordro personelBordro, string personelAdSoyad)
        {

            string masaUstuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string klasorYolu = Path.Combine(masaUstuYolu, personelAdSoyad.ToUpper());
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }

            string dosyaYolu = Path.Combine(klasorYolu, $"{personelAdSoyad.ToLower()}bordro.json");

            var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true };
            string jsonPersonel = System.Text.Json.JsonSerializer.Serialize(personelBordro,jsonAyarlar);
            File.WriteAllText(dosyaYolu, jsonPersonel);

            
        }

    }
}

