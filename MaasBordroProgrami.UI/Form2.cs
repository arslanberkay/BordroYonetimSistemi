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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordroProgrami.UI
{
    public partial class Form2 : Form
    {
        public Form2()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvPersonelYonetimi.ReadOnly = true; //Hücrelere basılıp değiştirilmemesi için kontrol altına aldım.
            txtKadro.ReadOnly = true;
            DereceGetir();
            dgvPersonelYonetimi.ClearSelection(); //Form açıldığında herhangi bir satırın seçili olmamasını sağlar.

            dgvPersonelYonetimi.Columns[2].DefaultCellStyle.Format = "C2";
            dgvPersonelYonetimi.Columns[2].DefaultCellStyle.FormatProvider = new CultureInfo("tr-TR");
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
            txtKadro.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[3].Value.ToString();
            mtxtCalismaSaati.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[2].Value.ToString();
            cbDerece.SelectedItem = dgvPersonelYonetimi.SelectedRows[0].Cells[4].Value.ToString();
            mtxtCalismaSaati.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[1].Value.ToString();

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
         
        }

        /// <summary>
        /// DataGridView'e gönderilen personeller listesinin elemanlarına yapılan değişiklikler sonrasında tablonun yenilenmesi için yazılmış bir metodtur.
        /// </summary>
        private void DataGridViewYenile()
        {
            dgvPersonelYonetimi.DataSource = null;
            dgvPersonelYonetimi.DataSource = personeller;
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonelYonetimi.SelectedRows.Count == 0) //Eğer satır seçilmemişse
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçiniz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(mtxtCalismaSaati.Text)) //Çalışma saati kontrolü
            {
                MessageBox.Show("Çalışma saati boş olmamalıdır!");
                return;
            }
            if (cbDerece.SelectedItem == null && txtKadro.Text == "Memur") //Memur için derece seçimi kontrolü
            {
                MessageBox.Show("Lütfen derece seçiniz!");
                return;
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

            MessageBox.Show("Güncelleme işlemi başarılıdır.");
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonelYonetimi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçiniz!");
                return;
            }

            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;
            personeller.RemoveAt(seciliIndex); //Seçili personeli listeden siler.

            DataGridViewYenile();
            JSONDosya.PersonelListesineKaydet(personeller.ToList()); //Güncellenen liste .json dosyasına yazılır.

            MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
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
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
