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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static List<MaasBordro> tumPersonelBordro = new List<MaasBordro>();

        private void TumCalisanBordroHesapla()
        {
            var personelListesi = JSONDosya.PersonelListesiOku().ToList();

            foreach (var item in personelListesi)
            {
                MaasBordro maasBordro = new MaasBordro();
                maasBordro.PersonelIsmi = item.AdSoyad;
                maasBordro.Kadro = item.Kadro;
                maasBordro.CalismaSaati = item.CalismaSaati;
                maasBordro.AnaOdeme = item.MaasHesapla();
                maasBordro.MesaiUcreti = item.MesaiHesapla();
                maasBordro.ToplamOdeme = item.MaasHesapla() + item.MesaiHesapla();

                tumPersonelBordro.Add(maasBordro);
            }
        }

        private void TabloOlustur()
        {
            lstvTumPersonelBordrosu.View = View.Details;
            lstvTumPersonelBordrosu.GridLines = true;
            lstvTumPersonelBordrosu.Columns.Add("Personel İsmi", 225);
            lstvTumPersonelBordrosu.Columns.Add("Kadro", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Çalışma Saati", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Ana Ödeme", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Mesai", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Toplam Ödeme", 225, HorizontalAlignment.Center);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TabloOlustur();
            TumCalisanBordroHesapla();

            foreach (var personel in tumPersonelBordro)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = personel.PersonelIsmi;
                listViewItem.SubItems.Add(personel.Kadro);
                listViewItem.SubItems.Add(personel.CalismaSaati.ToString());
                listViewItem.SubItems.Add(personel.AnaOdeme.ToString());
                listViewItem.SubItems.Add(personel.MesaiUcreti.ToString());
                listViewItem.SubItems.Add(personel.ToplamOdeme.ToString());

                lstvTumPersonelBordrosu.Items.Add(listViewItem);
            }
        }
    }
}
