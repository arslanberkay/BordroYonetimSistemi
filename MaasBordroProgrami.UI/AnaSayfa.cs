namespace MaasBordroProgrami.UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        
        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide(); //Mevcut formu gizler.
            PersonelYonetimi form2 = new PersonelYonetimi();
            form2.ShowDialog();

        }

        private void btnBordroHesaplama_Click(object sender, EventArgs e)
        {
            this.Hide();
            BordroHesaplama form4 = new BordroHesaplama();
            form4.ShowDialog();
        }

        private void btnTopluBordroGoruntule_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopluBordroHesaplama form5 = new TopluBordroHesaplama();
            form5.ShowDialog();
        }

        private void btnYeniPersonelKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelKayit form3 = new PersonelKayit();
            form3.ShowDialog();

        }

        private void btnUygulamadanCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
