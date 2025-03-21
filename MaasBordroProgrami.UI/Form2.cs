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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            VerileriYukle();
        }

        public static BindingList<IPersonel> personeller;

        private void Form2_Load(object sender, EventArgs e)
        {
            personeller = JSONDosya.PersonelListesiOku();
            dgvPersonelYonetimi.DataSource = personeller;

            txtAdSoyad.ReadOnly = txtKadro.ReadOnly = true;

           
            cbDerece.Items.Add("Düz Memur");
            cbDerece.Items.Add("Kıdemli Memur");
            cbDerece.Items.Add("Uzman Memur");
            cbDerece.Items.Add("Baş Memur");

        }

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

        private void btnYeniPersonelKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void dgvPersonelYonetimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonelYonetimi.SelectedRows.Count > 0)
            {
                txtAdSoyad.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[0].Value.ToString();
                txtKadro.Text = dgvPersonelYonetimi.SelectedRows[0].Cells[3].Value.ToString();
            }

            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;
            IPersonel seciliPersonel = personeller[seciliIndex];
            if (seciliPersonel.Kadro == "Yönetici")
            {
                cbDerece.Enabled = false;
            }
            else
            {
                cbDerece.Enabled = true;
            }
        }



        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtCalismaSaati.Text))
            {
                MessageBox.Show("Çalışma saati boş olmamalıdır!");
                return;
            }
            if (cbDerece.SelectedItem==null)
            {
                MessageBox.Show("Lütfen Personel seçiniz!");
                return;
            }
            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;
            IPersonel seciliPersonel = personeller[seciliIndex];

            seciliPersonel.CalismaSaati = Convert.ToInt32(mtxtCalismaSaati.Text);

            
            seciliPersonel.Derece = cbDerece.SelectedItem.ToString();

            dgvPersonelYonetimi.DataSource = null;
            dgvPersonelYonetimi.DataSource = personeller;

            JSONDosya.PersonelListesineKaydet(personeller.ToList());
            MessageBox.Show("Güncelleme işlemi başarılıdır.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = dgvPersonelYonetimi.SelectedRows[0].Index;

            personeller.RemoveAt(seciliIndex);

            dgvPersonelYonetimi.DataSource = null;
            dgvPersonelYonetimi.DataSource = personeller;

            JSONDosya.PersonelListesineKaydet(personeller.ToList());

            MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
        }
    }
}
