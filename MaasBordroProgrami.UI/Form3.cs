using MaasBordroProgrami.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            KontrolDuzenle(txtPersonelAdSoyad, "Ad soyad giriniz", 10, Color.DarkGray);
            KontrolDuzenle(cbPersonelKadro, "Kadro seçiniz", 10, Color.DarkGray);
        }

        /// <summary>
        /// Parametre olarak gönderilen kontrolün font ve renk düzenlemelerini veren içine ön bilgi koyabildiğimiz bir metod
        /// </summary>
        /// <param name="mesaj"></param>
        /// <param name="font"></param>
        /// <param name="renk"></param>
        private void KontrolDuzenle(Control control, string mesaj, float font, Color renk)
        {
            if (control is TextBox txt)
            {
                txt.Text = mesaj;
                txt.ForeColor = renk;
                txt.Font = new Font(txtPersonelAdSoyad.Font.FontFamily, font, txtPersonelAdSoyad.Font.Style);
            }
            else if (control is ComboBox cb)
            {
                cb.Text = mesaj;
                cb.ForeColor = renk;
                cb.Font = new Font(cbPersonelKadro.Font.FontFamily, font, cbPersonelKadro.Font.Style);


            }
        }


        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var personeller = JSONDosya.PersonelListesiOku(); //Güncel personel listemi .jsondan aldım.

                if ((string.IsNullOrWhiteSpace(txtPersonelAdSoyad.Text) || txtPersonelAdSoyad.Text == "Ad soyad giriniz") && cbPersonelKadro.SelectedItem == null) //Personel adı boşsa ve kadro seçilmediyse
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, "Personel adı boş bırakılamaz."); //Hata simgesi üzerine gelindiğinde bu mesajı gösterir.
                    epKadro.SetError(cbPersonelKadro, "Kadro bilgisi seçilmelidir."); //Hata simgesi üzerine gelindiğinde bu mesajı gösterir.
                    return;
                }
                else
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, string.Empty); // Hata temizleme
                    epKadro.SetError(cbPersonelKadro, string.Empty); // Hata temizleme
                }

                //Ad soyad arasında en az bir boşluk olması kontrolü ve Regex ile yanlızca harf kontrolü (Türkçe karakter olabilir)
                if (txtPersonelAdSoyad.Text.Trim().Split(' ').Length < 2 || !Regex.IsMatch(txtPersonelAdSoyad.Text, @"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]+$"))
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, "Ad ve soyad arasında en az bir boşluk olmalı ve yalnızca harflerden oluşmalıdır.");
                    return;
                }
                else
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, string.Empty);
                }


                if (string.IsNullOrWhiteSpace(txtPersonelAdSoyad.Text) || txtPersonelAdSoyad.Text == "Ad soyad giriniz")
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, "Personel adı boş bırakılamaz.");
                    return;
                }
                else
                {
                    epPersonelAdSoyad.SetError(txtPersonelAdSoyad, string.Empty);
                }
                if (cbPersonelKadro.SelectedItem == null)
                {
                    epKadro.SetError(cbPersonelKadro, "Kadro bilgisi seçilmelidir.");
                    return;
                }
                else
                {
                    epKadro.SetError(cbPersonelKadro, string.Empty);
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


                BildirimMesaji("Yeni personel başarıyla eklendi.", Color.FromArgb(0, 255, 0));

            }
            catch (Exception)
            {
                BildirimMesaji("Personel kaydetme sırasında hata oluştu.", Color.FromArgb(255, 0, 0));
            }
            finally
            {
                Temizle();
            }
        }

        private void BildirimMesaji(string mesaj, Color renk)
        {
            lblBildirim.ForeColor = renk;
            lblBildirim.Text = mesaj;
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
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        bool tiklandi = true;
        private void txtPersonelAdSoyad_Click(object sender, EventArgs e)
        {
            //Textboxta yapılan renk değişiminin ve ön bilgi temizlenmesinin ilk tıklamada yapılmasını daha sonraki tıklamalarda bu temizlenme işleminin yapılmaması gerektiği için bu şekilde bir kontrol ekledim
            if (tiklandi)
            {
                KontrolDuzenle(txtPersonelAdSoyad, string.Empty, 12, Color.Black);
                tiklandi = false;
            }

        }

        private void cbPersonelKadro_Click(object sender, EventArgs e)
        {
            KontrolDuzenle(cbPersonelKadro, string.Empty, 12, Color.Black);
            cbPersonelKadro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersonelKadro.SelectedItem = null;
        }
    }
}
