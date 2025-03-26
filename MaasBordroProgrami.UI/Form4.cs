using MaasBordroProgrami.Core.Data;
using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordroProgrami.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maaş bordrosu için bir ListView(tablo) oluşturur.
        /// </summary>
        private void TabloOlustur()
        {
            lstvPersonelBordrosu.View = View.Details;
            lstvPersonelBordrosu.GridLines = true;
            lstvPersonelBordrosu.Columns.Add("Ad - Soyad", 215, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Kadro", 215, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Çalışma Saati", 215, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Ana Ödeme", 215, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Mesai Ücreti", 215, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Toplam Ödeme", 215, HorizontalAlignment.Center);
        }

        private List<IPersonel> personelListesi;

        private void Form4_Load(object sender, EventArgs e)
        {
            personelListesi = JSONDosya.PersonelListesiOku().ToList(); //JSON formatındaki personel listesini okur.

            TabloOlustur();

            foreach (var personel in personelListesi)
            {
                cbPersonelAdSoyad.Items.Add(personel.AdSoyad);
            }
        }

        private void Temizle()
        {
            lstvPersonelBordrosu.Clear();
            TabloOlustur();
        }

        private void cbPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            epPersonel.SetError(cbPersonelAdSoyad, string.Empty); //Personel seçildiğinde uyarı ikonunu temizle

            if (cbPersonelAdSoyad.SelectedItem == null)
            {
                MessageBox.Show("Personel seçimi boş geçilemez!");
                return;
            }

            int seciliIndex = cbPersonelAdSoyad.SelectedIndex;
            IPersonel seciliPersonel = personelListesi[seciliIndex]; //Combobox'tan seçilen personel alınır.

            //Seçili personelin bilgilerine bağlı olarak maasBordro bilgileri atanır.
            MaasBordro maasBordro = new MaasBordro();
            maasBordro.PersonelIsmi = seciliPersonel.AdSoyad;
            maasBordro.CalismaSaati = seciliPersonel.CalismaSaati;
            maasBordro.AnaOdeme = seciliPersonel.MaasHesapla();
            maasBordro.MesaiUcreti = seciliPersonel.MesaiHesapla();
            maasBordro.ToplamOdeme = seciliPersonel.MaasHesapla() + seciliPersonel.MesaiHesapla();

            //Tüm bilgiler yeni bir satır olarak tabloya eklebir.
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = maasBordro.PersonelIsmi;
            listViewItem.SubItems.Add(seciliPersonel.Kadro.ToString());
            listViewItem.SubItems.Add(maasBordro.CalismaSaati.ToString());
            listViewItem.SubItems.Add(maasBordro.AnaOdeme.ToString("C"));
            listViewItem.SubItems.Add(maasBordro.MesaiUcreti.ToString("C"));
            listViewItem.SubItems.Add(maasBordro.ToplamOdeme.ToString("C"));

            lstvPersonelBordrosu.Items.Add(listViewItem);
        }


        private void btnJsonDosyaKaydet_Click(object sender, EventArgs e)
        {
            if (cbPersonelAdSoyad.SelectedItem == null)
            {
                epPersonel.SetError(cbPersonelAdSoyad, "Personel seçimi yapılmalıdır.");
                return;
            }
            else
            {
                epPersonel.SetError(cbPersonelAdSoyad, string.Empty);
            }

            int seciliIndex = cbPersonelAdSoyad.SelectedIndex;
            IPersonel seciliPersonel = personelListesi[seciliIndex]; //Seçili personel alınır.

            //Maaş Bordro bilgileri atanır.
            MaasBordro maasBordro = new MaasBordro();
            maasBordro.PersonelIsmi = seciliPersonel.AdSoyad;
            maasBordro.CalismaSaati = seciliPersonel.CalismaSaati;
            maasBordro.Kadro = seciliPersonel.Kadro;
            maasBordro.BordroTarihi = DateTime.Now.ToString("yyyy-MMMM");
            maasBordro.AnaOdeme = seciliPersonel.MaasHesapla();
            maasBordro.MesaiUcreti = seciliPersonel.MesaiHesapla();
            maasBordro.ToplamOdeme = seciliPersonel.MaasHesapla() + seciliPersonel.MesaiHesapla();

            try
            {
                JSONDosya.PersonelAdinaKaydet(maasBordro, maasBordro.PersonelIsmi); //Seçilen personelin maasBordrosu JSON formatında kaydedilir.

                BildirimMesaji($"Bordro dosyası başarıyla kaydedildi.", Color.Green);

            }
            catch (Exception)
            {
                BildirimMesaji("Bordro dosyası kaydedilirken hata oluştu!", Color.Red);
            }
            finally //Her türlü temizlenme işlemi gerçekleşsin
            {
                Temizle();
                cbPersonelAdSoyad.SelectedItem = null;
            }
        }


        private void BildirimMesaji(string mesaj, Color renk)
        {
            lblBildirim.ForeColor = renk;
            lblBildirim.Text = mesaj;
        }

        private void btnAnaSayfayaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }


    }
}
