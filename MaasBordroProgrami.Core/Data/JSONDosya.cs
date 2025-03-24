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
        //Bu class personel listesini JSON formatında saklamak,okumak ve belirli bir personelin maaş bordrosunu kaydetmek için oluşturulmuştur.

        /// <summary>
        /// Bu metod data.json dosyasından personel listesini okuyup BindingList<IPersonel> türünde bir liste olarak döndürür.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static BindingList<IPersonel> PersonelListesiOku()
        {
            //Dosya Yolunu Belirleme
            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //Programın çalıştığı dizini bulur
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "PersonelData"); //Data klasöründeki data.json dosyasının tam yolunu oluşturur.
            string jsonDosyaYolu = Path.Combine(hedefDizin, "personel.json");

            if (!File.Exists(jsonDosyaYolu)) //Dosya mevcut değilse hata fırlatır.
            {
                throw new Exception("JSON dosyası bulunamadı.");
            }

            //JSON Verisin Okuma
            string jsonVeri = File.ReadAllText(jsonDosyaYolu); //JSON dosyasının tamamını okur
            var hamListe = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonVeri); //JSON'u List<Dictionary<string,object>> türüne çevirir. (esnek bir yapı için)

            //Personel Tipine Göre Nesne Oluşturma
            var personelListesi = new BindingList<IPersonel>(); //List benzeri bir yapıdır . Özellikle veri bağlama (data binding) işlemleri için geliştirilmiştir. Binding sayesinde listeye yeni bir personel eklendiğinde silindiğinde elle güncellemek zorunda kalmayız. Windows Forms projelerinde tercih edilir çünkü DataGridView, ListView gibi arayüz bileşenleriyle uyumlu,sorunsuz çalışır. List kullandığım zaman form bileşenleriyle kontak olması için çok fazla güncelleme işlemi yapmam gerekti. BindingList tüm bu işlemleri dinamikleştirdi.

            //Amaç: JSON'dan gelen veriyi, projede tanımlanmış Memur,Yonetici sınıfına dönüştürüp BindingList içine eklemek.
            foreach (var item in hamListe)
            {
                if (item.ContainsKey("Kadro") && item["Kadro"].ToString() == "Yönetici") //Kadro varsa ve Yönetici ise 
                {
                    var yonetici = JsonConvert.DeserializeObject<Yonetici>(JsonConvert.SerializeObject(item)); //item nesnesini JSON(string) formatına dönüştürür. Daha sonra JSON formatındaki veriyi Yonetici türünde bir nesneye çevirir.
                    personelListesi.Add(yonetici);
                }
                else if (item.ContainsKey("Kadro") && item["Kadro"].ToString() == "Memur") //Kadro varsa ve Memur ise
                {
                    var memur = JsonConvert.DeserializeObject<Memur>(JsonConvert.SerializeObject(item)); //item nesnesini JSON(string) formatına dönüştürür. Daha sonra JSON formatındaki veriyi Memur türünde bir nesneye çevirir.
                    personelListesi.Add(memur);
                }
            }
            return personelListesi;
        }

        /// <summary>
        /// Bu metod List<IPersonel> türündeki personel listesini JSON formatında data.json dosyasına kaydeder.
        /// </summary>
        /// <param name="personelListesi"></param>
        public static void PersonelListesineKaydet(List<IPersonel> personelListesi)
        {
            //Dosya Yolu Oluşturma
            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "PersonelData");
            string jsonDosyaYolu = Path.Combine(hedefDizin, "personel.json");

            //personelListesi'ni JSON Nesnesine Dönüştürme
            var jsonListesi = new List<object>();

            foreach (var personel in personelListesi)
            {
                //Her personel nesnesinden anonim bir nesne oluşturulur (new { } yapısı)
                //Bu nesneler jsonListesi adlı listeye eklenir.
                jsonListesi.Add(new
                {
                    personel.AdSoyad,
                    personel.CalismaSaati,
                    personel.SaatlikUcret,
                    personel.Kadro,
                    personel.Derece
                });
            }

            string jsonVeri = JsonConvert.SerializeObject(jsonListesi, Formatting.Indented); //Nesneyi JSON formatına dönüştürür. Formatting.Indented : JSON çıktısını düzenli hale getirir.
            File.WriteAllText(jsonDosyaYolu, jsonVeri); //JSON verisini belirtilen dosya yoluna yazar.

        }

        /// <summary>
        /// Bu metod personelin maaş bordrosunu kişinin adını taşıyan bir klasöre kaydeder.
        /// </summary>
        /// <param name="personelBordro"></param>
        /// <param name="personelAdSoyad"></param>
        public static void PersonelAdinaKaydet(MaasBordro personelBordro, string personelAdSoyad)
        {
            //Masaüstü Yolu ve Hedef Klasör Oluşturma
            string masaUstuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //Kullanıcının masaüstü dizinini alır.

            string klasorYolu = Path.Combine(masaUstuYolu, $"{personelAdSoyad.ToUpper()}");
            if (!Directory.Exists(klasorYolu)) //Klasör yoksa
            {
                Directory.CreateDirectory(klasorYolu);
            }

            //JSON Dosya Adı ve Yolu Oluşturma
            string dosyaYolu = Path.Combine(klasorYolu, $"{personelAdSoyad.Replace(" ", "-")}-{DateTime.Now:yyyy-MM}-Bordro.json");

            //Maaş Bordrsounu JSON Olarak Kaydetme
            var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true };
            string jsonPersonel = System.Text.Json.JsonSerializer.Serialize(personelBordro, jsonAyarlar); //MaasBordro nesnesini JSON formatına dönüştürür
            File.WriteAllText(dosyaYolu, jsonPersonel); //JSON çıktısı masaüstündeki ilgili klasöre kaydedilir.
        }

    }
}

