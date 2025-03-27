namespace MaasBordroProgrami.UI
{
    partial class PersonelKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelKayit));
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbPersonelKadro = new ComboBox();
            txtPersonelAdSoyad = new TextBox();
            label2 = new Label();
            btnPersonelEkle = new Button();
            ımageList1 = new ImageList(components);
            btnPersonelYonetimSayfasinaGeriGec = new Button();
            epPersonelAdSoyad = new ErrorProvider(components);
            epKadro = new ErrorProvider(components);
            lblBildirim = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epPersonelAdSoyad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epKadro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPersonelKadro);
            groupBox1.Controls.Add(txtPersonelAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(540, 259);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(352, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // cbPersonelKadro
            // 
            cbPersonelKadro.BackColor = Color.WhiteSmoke;
            cbPersonelKadro.FormattingEnabled = true;
            cbPersonelKadro.Location = new Point(135, 94);
            cbPersonelKadro.Name = "cbPersonelKadro";
            cbPersonelKadro.Size = new Size(191, 36);
            cbPersonelKadro.TabIndex = 2;
            cbPersonelKadro.Click += cbPersonelKadro_Click;
            // 
            // txtPersonelAdSoyad
            // 
            txtPersonelAdSoyad.BackColor = Color.WhiteSmoke;
            txtPersonelAdSoyad.Location = new Point(135, 45);
            txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            txtPersonelAdSoyad.Size = new Size(191, 34);
            txtPersonelAdSoyad.TabIndex = 1;
            txtPersonelAdSoyad.Click += txtPersonelAdSoyad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "Kadro ";
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.BackColor = Color.Gainsboro;
            btnPersonelEkle.ForeColor = Color.Black;
            btnPersonelEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonelEkle.ImageIndex = 0;
            btnPersonelEkle.ImageList = ımageList1;
            btnPersonelEkle.Location = new Point(540, 427);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(352, 52);
            btnPersonelEkle.TabIndex = 1;
            btnPersonelEkle.Text = "Personel Ekle";
            btnPersonelEkle.UseVisualStyleBackColor = false;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "9035989_person_add_sharp_icon.png");
            ımageList1.Images.SetKeyName(1, "9054423_bx_arrow_back_icon.png");
            // 
            // btnPersonelYonetimSayfasinaGeriGec
            // 
            btnPersonelYonetimSayfasinaGeriGec.BackColor = Color.Gainsboro;
            btnPersonelYonetimSayfasinaGeriGec.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPersonelYonetimSayfasinaGeriGec.ImageIndex = 1;
            btnPersonelYonetimSayfasinaGeriGec.ImageList = ımageList1;
            btnPersonelYonetimSayfasinaGeriGec.Location = new Point(30, 25);
            btnPersonelYonetimSayfasinaGeriGec.Name = "btnPersonelYonetimSayfasinaGeriGec";
            btnPersonelYonetimSayfasinaGeriGec.Size = new Size(37, 35);
            btnPersonelYonetimSayfasinaGeriGec.TabIndex = 2;
            btnPersonelYonetimSayfasinaGeriGec.UseVisualStyleBackColor = false;
            btnPersonelYonetimSayfasinaGeriGec.Click += btnPersonelYonetimSayfasinaGeriGec_Click;
            // 
            // epPersonelAdSoyad
            // 
            epPersonelAdSoyad.ContainerControl = this;
            // 
            // epKadro
            // 
            epKadro.ContainerControl = this;
            // 
            // lblBildirim
            // 
            lblBildirim.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBildirim.Location = new Point(540, 25);
            lblBildirim.Name = "lblBildirim";
            lblBildirim.Size = new Size(566, 103);
            lblBildirim.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.depositphotos_537805212_stock_illustration_lion_head_logo_design_vector_Photoroom;
            pictureBox1.Location = new Point(1380, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Handwriting", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1372, 86);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 8;
            label3.Text = "ArslanSoft";
            // 
            // PersonelKayit
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1482, 753);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(lblBildirim);
            Controls.Add(btnPersonelYonetimSayfasinaGeriGec);
            Controls.Add(btnPersonelEkle);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PersonelKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Kayıt";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epPersonelAdSoyad).EndInit();
            ((System.ComponentModel.ISupportInitialize)epKadro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnPersonelEkle;
        private ComboBox cbPersonelKadro;
        private TextBox txtPersonelAdSoyad;
        private Button btnPersonelYonetimSayfasinaGeriGec;
        private ImageList ımageList1;
        private ErrorProvider epPersonelAdSoyad;
        private ErrorProvider epKadro;
        private Label lblBildirim;
        private PictureBox pictureBox1;
        private Label label3;
    }
}