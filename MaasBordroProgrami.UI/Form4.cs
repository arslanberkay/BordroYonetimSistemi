using MaasBordroProgrami.Core.Data;
using MaasBordroProgrami.Core.Interfaces;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void TabloOlustur()
        {
            lstvPersonelBordrosu.View = View.Details;
            lstvPersonelBordrosu.GridLines = true;
            lstvPersonelBordrosu.Columns.Add("Personel Ad - Soyad", 225);
            lstvPersonelBordrosu.Columns.Add("Kadro", 225, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Çalışma Saati", 225, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Ana Ödeme", 225, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Mesai Ücreti", 225, HorizontalAlignment.Center);
            lstvPersonelBordrosu.Columns.Add("Toplam Ödeme", 225, HorizontalAlignment.Center);

        }

        private List<IPersonel> personelListesi;

        private void Form4_Load(object sender, EventArgs e)
        {
            personelListesi = JSONDosya.PersonelListesiOku().ToList();

            TabloOlustur();

            foreach (var item in personelListesi)
            {
                cbPersonelAdSoyad.Items.Add(item.AdSoyad);
            }
        }

        private void btnAnaSayfayaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnBordroHesapla_Click(object sender, EventArgs e)
        {
            if (cbPersonelAdSoyad.SelectedItem == null)
            {
                MessageBox.Show("Personel seçimi boş geçilemez!");
                return;
            }

            int seciliIndex = cbPersonelAdSoyad.SelectedIndex;
            IPersonel seciliPersonel = personelListesi[seciliIndex];

            MaasBordro maasBordro = new MaasBordro();
            maasBordro.PersonelIsmi = seciliPersonel.AdSoyad;
            maasBordro.CalismaSaati = seciliPersonel.CalismaSaati;
            maasBordro.ToplamOdeme = seciliPersonel.MaasHesapla();

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = maasBordro.PersonelIsmi;
            listViewItem.SubItems.Add(seciliPersonel.Kadro.ToString());
            listViewItem.SubItems.Add(maasBordro.CalismaSaati.ToString());
            listViewItem.SubItems.Add(maasBordro.ToplamOdeme.ToString());

            lstvPersonelBordrosu.Items.Add(listViewItem);


        }
    }
}
