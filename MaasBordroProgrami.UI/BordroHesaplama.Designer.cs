namespace MaasBordroProgrami.UI
{
    partial class BordroHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BordroHesaplama));
            label1 = new Label();
            cbPersonelAdSoyad = new ComboBox();
            ımageList2 = new ImageList(components);
            lstvPersonelBordrosu = new ListView();
            btnAnaSayfayaGeriGec = new Button();
            ımageList1 = new ImageList(components);
            btnJsonDosyaKaydet = new Button();
            epPersonel = new ErrorProvider(components);
            lblBildirim = new Label();
            pictureBox1 = new PictureBox();
            btnBordroHesapla = new Button();
            epBordroHesapla = new ErrorProvider(components);
            ımageList3 = new ImageList(components);
            lblBilgi = new Label();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)epPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epBordroHesapla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(554, 31);
            label1.TabIndex = 0;
            label1.Text = "Bordrosunu Hesaplamak İstediğiniz Personeli Seçiniz \r\n";
            // 
            // cbPersonelAdSoyad
            // 
            cbPersonelAdSoyad.BackColor = Color.WhiteSmoke;
            cbPersonelAdSoyad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersonelAdSoyad.FormattingEnabled = true;
            cbPersonelAdSoyad.Location = new Point(671, 176);
            cbPersonelAdSoyad.Name = "cbPersonelAdSoyad";
            cbPersonelAdSoyad.Size = new Size(307, 33);
            cbPersonelAdSoyad.TabIndex = 1;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "9104302_save_storage_file_document_page_icon.png");
            ımageList2.Images.SetKeyName(1, "9868525_device_calculator_finance_calculation_calculate_icon.png");
            // 
            // lstvPersonelBordrosu
            // 
            lstvPersonelBordrosu.BackColor = Color.WhiteSmoke;
            lstvPersonelBordrosu.Location = new Point(105, 318);
            lstvPersonelBordrosu.Name = "lstvPersonelBordrosu";
            lstvPersonelBordrosu.Size = new Size(1299, 90);
            lstvPersonelBordrosu.TabIndex = 3;
            lstvPersonelBordrosu.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.BackColor = Color.Gainsboro;
            btnAnaSayfayaGeriGec.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnAnaSayfayaGeriGec.ImageIndex = 0;
            btnAnaSayfayaGeriGec.ImageList = ımageList1;
            btnAnaSayfayaGeriGec.Location = new Point(30, 25);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(37, 35);
            btnAnaSayfayaGeriGec.TabIndex = 4;
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = false;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "9054423_bx_arrow_back_icon.png");
            // 
            // btnJsonDosyaKaydet
            // 
            btnJsonDosyaKaydet.BackColor = Color.Gainsboro;
            btnJsonDosyaKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnJsonDosyaKaydet.ImageKey = "9104302_save_storage_file_document_page_icon.png";
            btnJsonDosyaKaydet.ImageList = ımageList2;
            btnJsonDosyaKaydet.Location = new Point(1097, 428);
            btnJsonDosyaKaydet.Name = "btnJsonDosyaKaydet";
            btnJsonDosyaKaydet.Size = new Size(307, 65);
            btnJsonDosyaKaydet.TabIndex = 2;
            btnJsonDosyaKaydet.Text = "Dosya Olarak Kaydet";
            btnJsonDosyaKaydet.UseVisualStyleBackColor = false;
            btnJsonDosyaKaydet.Click += btnJsonDosyaKaydet_Click;
            // 
            // epPersonel
            // 
            epPersonel.ContainerControl = this;
            // 
            // lblBildirim
            // 
            lblBildirim.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBildirim.Location = new Point(540, 25);
            lblBildirim.Name = "lblBildirim";
            lblBildirim.Size = new Size(616, 86);
            lblBildirim.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.depositphotos_537805212_stock_illustration_lion_head_logo_design_vector_Photoroom;
            pictureBox1.Location = new Point(1380, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnBordroHesapla
            // 
            btnBordroHesapla.BackColor = Color.Gainsboro;
            btnBordroHesapla.ImageAlign = ContentAlignment.MiddleLeft;
            btnBordroHesapla.ImageIndex = 1;
            btnBordroHesapla.ImageList = ımageList2;
            btnBordroHesapla.Location = new Point(671, 227);
            btnBordroHesapla.Name = "btnBordroHesapla";
            btnBordroHesapla.Size = new Size(307, 65);
            btnBordroHesapla.TabIndex = 7;
            btnBordroHesapla.Text = "Bordro Hesapla";
            btnBordroHesapla.UseVisualStyleBackColor = false;
            btnBordroHesapla.Click += btnBordroHesapla_Click;
            // 
            // epBordroHesapla
            // 
            epBordroHesapla.ContainerControl = this;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "5402388_information_about_support_accessibility_info_icon.png");
            ımageList3.Images.SetKeyName(1, "3937344_help_helpdesk_info_information_question_icon.png");
            // 
            // lblBilgi
            // 
            lblBilgi.ImageKey = "3937344_help_helpdesk_info_information_question_icon.png";
            lblBilgi.ImageList = ımageList3;
            lblBilgi.Location = new Point(1040, 428);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(51, 65);
            lblBilgi.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1372, 86);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 10;
            label2.Text = "ArslanSoft";
            // 
            // BordroHesaplama
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1482, 753);
            Controls.Add(label2);
            Controls.Add(lblBilgi);
            Controls.Add(btnBordroHesapla);
            Controls.Add(pictureBox1);
            Controls.Add(lblBildirim);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(lstvPersonelBordrosu);
            Controls.Add(btnJsonDosyaKaydet);
            Controls.Add(cbPersonelAdSoyad);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BordroHesaplama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bordro Hesaplama";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)epPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)epBordroHesapla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbPersonelAdSoyad;
        private ListView lstvPersonelBordrosu;
        private Button btnAnaSayfayaGeriGec;
        private Button btnJsonDosyaKaydet;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private ErrorProvider epPersonel;
        private Label lblBildirim;
        private PictureBox pictureBox1;
        private Button btnBordroHesapla;
        private ErrorProvider epBordroHesapla;
        private Label lblBilgi;
        private ImageList ımageList3;
        private ToolTip toolTip1;
        private Label label2;
    }
}