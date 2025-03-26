using iTextSharp.text.pdf;
using MaasBordroProgrami.Core.Data;
using MaasBordroProgrami.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordroProgrami.UI
{
    public partial class PersonelYonetimi : Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
            VerileriYukle();
        }

        public static BindingList<IPersonel> personeller; //Verileri otomatik olarak güncelleyen .json ile dynamic çalışan bir koleksiyon yapısı olan BindingListte personellerimi tuttum.

        /// <summary>
        /// JSON dosyasından personel bilgilerini okuyup DataGridView'e yükler.
        /// </summary>
        private void VerileriYukle()
        {
            try
            {
                personeller = new BindingList<IPersonel>(JSONDosya.PersonelListesiOku());
                dgvPersonelYonetimi.DataSource = personeller;
                dgvPersonelYonetimi.Columns[0].HeaderText = "Ad Soyad";
                dgvPersonelYonetimi.Columns[1].HeaderText = "Kadro";
                dgvPersonelYonetimi.Columns[2].HeaderText = "Derece";
                dgvPersonelYonetimi.Columns[3].HeaderText = "Çalışma Saati";
                dgvPersonelYonetimi.Columns[4].HeaderText = "Saatlik Ücret";

            }
            catch (Exception ex)
            {
                BildirimMesaji($"Veri yüklenirken hata oluştu : {ex.Message}", Color.FromArgb(255, 0, 0));
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvPersonelYonetimi.ReadOnly = true; //Hücrelere basılıp değiştirilmemesi için kontrol altına aldım.
            txtKadro.ReadOnly = true;
            DereceGetir();
            dgvPersonelYonetimi.ClearSelection(); //Form açıldığında herhangi bir satırın seçili olmamasını sağlar.

            dgvPersonelYonetimi.Columns[4].DefaultCellStyle.Format = "C2";
            dgvPersonelYonetimi.Columns[4].DefaultCellStyle.FormatProvider = new CultureInfo("tr-TR");
        }

        /// <summary>
        /// Dereceleri comboboxa ekler.
        /// </summary>
        private void DereceGetir()
        {
            //İsteğe göre derece arttırılıp azaltılabilir. Switch expression ile kontak bir şekilde !
            List<string> dereceler = new List<string> { "Düz Memur", "Kıdemli Memur", "Uzman Memur", "Baş Memur" };
            foreach (var derece in dereceler)
            {
                cbDerece.Items.Add(derece);
            }
        }

        private void dgvPersonelYonetimi_CellClick(object sender, DataGridViewCellEventArgs e) //Hücreye tıklayınca
        {
            txtAdSoyad.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[0].Value.ToString();
            txtKadro.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[1].Value.ToString();
            mtxtCalismaSaati.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[3].Value.ToString();
            cbDerece.SelectedItem = dgvPersonelYonetimi.SelectedRows[0].Cells[2].Value.ToString();

            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;
            IPersonel seciliPersonel = personeller[seciliIndex];
            if (seciliPersonel.Kadro == "Yönetici") //Eğer seçilen personelin kadrosu "Yönetici" ise 
            {
                //Derece seçimi devre dışı bırakılır
                cbDerece.Text = string.Empty;
                cbDerece.SelectedItem = null;
                cbDerece.Enabled = false;
            }
            else
            {
                cbDerece.Enabled = true;
            }

            //Tablodan seçim yapıldığında hata mesajları ve bildirimler temizlendi.
            epCalismaSaati.SetError(mtxtCalismaSaati, string.Empty);
            epAdSoyad.SetError(txtAdSoyad, string.Empty);
            BildirimMesaji(string.Empty, Color.Transparent);
        }

        /// <summary>
        /// DataGridView'e gönderilen personeller listesinin elemanlarına yapılan değişiklikler sonrasında tablonun yenilenmesi için yazılmış bir metodtur.
        /// </summary>
        private void DataGridViewYenile()
        {
            dgvPersonelYonetimi.DataSource = null;
            dgvPersonelYonetimi.DataSource = personeller;
        }

        private void BildirimMesaji(string mesaj, Color renk)
        {
            lblBildirim.ForeColor = renk;
            lblBildirim.Text = mesaj;
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonelYonetimi.SelectedRows.Count == 0) //Eğer satır seçilmemişse
            {
                BildirimMesaji($"Lütfen güncelleme işlemi için bir personel seçin!", Color.Red);
                return;
            }

            //Ad soyad arasında en az bir boşluk olması kontrolü ve Regex ile yanlızca harf kontrolü (Türkçe karakter olabilir)
            if (txtAdSoyad.Text.Split(' ').Length < 2 || !Regex.IsMatch(txtAdSoyad.Text, @"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]+$"))
            {
                epAdSoyad.SetError(txtAdSoyad, "Ad ve soyad arasında en az bir boşluk olmalı ve yalnızca harflerden oluşmalıdır.");
                return;
            }
            else
            {
                epAdSoyad.SetError(txtAdSoyad, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(mtxtCalismaSaati.Text))
            {
                epCalismaSaati.SetError(mtxtCalismaSaati, "Çalışma saati girilmelidir");
                return;
            }
            else
            {
                epCalismaSaati.SetError(mtxtCalismaSaati, string.Empty);
            }

            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index; //Seçili satırın indexi
            IPersonel seciliPersonel = personeller[seciliIndex]; //Listeden o indexe ait olan personel nesnemi buldum.

            seciliPersonel.AdSoyad = txtAdSoyad.Text;

            if (seciliPersonel.Kadro == "Memur") //Şart eklenmese de olur (cell clickte kontrol ediliyor) sonrasında farklı personel kadroları geldiğinde karışıklık olmaması adına ekledim.
            {
                seciliPersonel.Derece = cbDerece.SelectedItem.ToString();
            }

            seciliPersonel.CalismaSaati = Convert.ToInt32(mtxtCalismaSaati.Text);

            DataGridViewYenile();
            JSONDosya.PersonelListesineKaydet(personeller.ToList()); //Güncellenmiş listeyi .json dosyasına yazar

            BildirimMesaji("Personel bilgileri başarıyla güncellendi.", Color.FromArgb(0, 255, 0));
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonelYonetimi.SelectedRows.Count == 0)
            {
                BildirimMesaji("Silme işlemi için lütfen bir personel seçin!", Color.FromArgb(255, 0, 0));
                return;
            }

            //Personel silme işlemi yanlışlıkla tıklamaya karşı doğrulama bildirimi
            DialogResult dr = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) //Cevap hayırsa
            {
                BildirimMesaji("Silme işlemi iptal edildi.", Color.FromArgb(0, 255, 0));
                return;
            }

            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;
            personeller.RemoveAt(seciliIndex); //Seçili personeli listeden siler.

            DataGridViewYenile();
            JSONDosya.PersonelListesineKaydet(personeller.ToList()); //Güncellenen liste .json dosyasına yazılır.

            BildirimMesaji("Personel kaydı başarıyla silindi.", Color.FromArgb(0, 255, 0));
            Temizle();
        }

        /// <summary>
        /// Form ekranındaki girişleri sıfırlar. 
        /// </summary>
        private void Temizle()
        {
            txtAdSoyad.Text = txtKadro.Text = mtxtCalismaSaati.Text = string.Empty;
            cbDerece.SelectedItem = null;
            dgvPersonelYonetimi.ClearSelection();
        }

        private void btnAnaSayfayaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa form1 = new AnaSayfa();
            form1.ShowDialog();
        }


    }
}
