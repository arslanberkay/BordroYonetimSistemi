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

        public void KadroGetir()
        {
            cbPersonelKadro.Items.Add("Yönetici");
            cbPersonelKadro.Items.Add("Memur");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KadroGetir();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            var personeller = JSONDosya.PersonelListesiOku();

            if (string.IsNullOrWhiteSpace(txtPersonelAdSoyad.Text))
            {
                MessageBox.Show("Ad-Soyad boş olamaz!");
                return;
            }
            if (cbPersonelKadro.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kadro seçimi yapınız!");
                return;
            }

            if (cbPersonelKadro.SelectedItem == "Yönetici")
            {
                personeller.Add(new Yonetici { AdSoyad = txtPersonelAdSoyad.Text, Kadro = "Yönetici" });
            }
            else
            {
                personeller.Add(new Memur { AdSoyad = txtPersonelAdSoyad.Text, Kadro = "Memur" });
            }

            JSONDosya.PersonelListesineKaydet(personeller.ToList());

            MessageBox.Show("Personel başarıyla eklendi.");
            Temizle();
        }

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
