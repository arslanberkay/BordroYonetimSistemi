using MaasBordroProgrami.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordroProgrami.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kadro seçeneklerini comboboxta göstermeye yarayan metod
        /// </summary>
        public void KadroGetir()
        {
            List<string> kadrolar = new List<string> { "Yönetici", "Memur" }; //Yeni bir personel kadrosu gelirse eklenebilir.
            foreach (var kadro in kadrolar)
            {
                cbPersonelKadro.Items.Add(kadro);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KadroGetir();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            var personeller = JSONDosya.PersonelListesiOku(); //Güncel personel listemi .jsondan aldım.

            if (string.IsNullOrWhiteSpace(txtPersonelAdSoyad.Text)) //Ad-Soyad kontrolü
            {
                MessageBox.Show("Ad-Soyad boş olamaz!");
                return;
            }
            if (cbPersonelKadro.SelectedItem == null) //Kadro kontrolü
            {
                MessageBox.Show("Lütfen kadro seçimi yapınız!");
                return;
            }

            if (cbPersonelKadro.SelectedItem == "Yönetici") //Yönetici seçildiyse
            {
                personeller.Add(new Yonetici { AdSoyad = txtPersonelAdSoyad.Text, Kadro = "Yönetici" }); //Yeni Yonetici nesnesi listeye eklenir (object initializer kullanılarak nesne oluşturuldu ve özellikleri verildi.)
            }
            else if (cbPersonelKadro.SelectedItem == "Memur") //Memur seçildiyse
            {
                personeller.Add(new Memur { AdSoyad = txtPersonelAdSoyad.Text, Kadro = "Memur" }); //Yeni Memur nesnesi listeye eklenir.
            }

            JSONDosya.PersonelListesineKaydet(personeller.ToList()); //Yeni eklenen personel JSON dosyasına kalıcı olarak kaydedilir.

            MessageBox.Show("Personel başarıyla eklendi.");
            Temizle();
        }

        /// <summary>
        /// Formdaki giriş alanlarını sıfırlayan metod
        /// </summary>
        private void Temizle()
        {
            txtPersonelAdSoyad.Text = string.Empty;
            cbPersonelKadro.SelectedItem = null;
        }

        private void btnPersonelYonetimSayfasinaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

    }
}
