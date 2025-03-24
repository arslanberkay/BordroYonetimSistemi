namespace MaasBordroProgrami.UI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            cbPersonelAdSoyad = new ComboBox();
            btnBordroHesapla = new Button();
            ımageList2 = new ImageList(components);
            lstvPersonelBordrosu = new ListView();
            btnAnaSayfayaGeriGec = new Button();
            ımageList1 = new ImageList(components);
            btnJsonDosyaKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(559, 31);
            label1.TabIndex = 0;
            label1.Text = "Bordrosunu Hesaplamak İstediğiniz Personeli Seçiniz :";
            // 
            // cbPersonelAdSoyad
            // 
            cbPersonelAdSoyad.BackColor = Color.WhiteSmoke;
            cbPersonelAdSoyad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersonelAdSoyad.FormattingEnabled = true;
            cbPersonelAdSoyad.Location = new Point(639, 77);
            cbPersonelAdSoyad.Name = "cbPersonelAdSoyad";
            cbPersonelAdSoyad.Size = new Size(239, 33);
            cbPersonelAdSoyad.TabIndex = 1;
            // 
            // btnBordroHesapla
            // 
            btnBordroHesapla.BackColor = Color.Gainsboro;
            btnBordroHesapla.ImageAlign = ContentAlignment.MiddleLeft;
            btnBordroHesapla.ImageIndex = 1;
            btnBordroHesapla.ImageList = ımageList2;
            btnBordroHesapla.Location = new Point(639, 127);
            btnBordroHesapla.Name = "btnBordroHesapla";
            btnBordroHesapla.Size = new Size(239, 55);
            btnBordroHesapla.TabIndex = 2;
            btnBordroHesapla.Text = "Bordro Hesapla";
            btnBordroHesapla.UseVisualStyleBackColor = false;
            btnBordroHesapla.Click += btnBordroHesapla_Click;
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
            lstvPersonelBordrosu.Location = new Point(73, 199);
            lstvPersonelBordrosu.Name = "lstvPersonelBordrosu";
            lstvPersonelBordrosu.Size = new Size(1292, 90);
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
            btnJsonDosyaKaydet.Location = new Point(1064, 306);
            btnJsonDosyaKaydet.Name = "btnJsonDosyaKaydet";
            btnJsonDosyaKaydet.Size = new Size(300, 55);
            btnJsonDosyaKaydet.TabIndex = 2;
            btnJsonDosyaKaydet.Text = "Dosya Olarak Kaydet";
            btnJsonDosyaKaydet.UseVisualStyleBackColor = false;
            btnJsonDosyaKaydet.Click += btnJsonDosyaKaydet_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1423, 410);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(lstvPersonelBordrosu);
            Controls.Add(btnJsonDosyaKaydet);
            Controls.Add(btnBordroHesapla);
            Controls.Add(cbPersonelAdSoyad);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbPersonelAdSoyad;
        private Button btnBordroHesapla;
        private ListView lstvPersonelBordrosu;
        private Button btnAnaSayfayaGeriGec;
        private Button btnJsonDosyaKaydet;
        private ImageList ımageList1;
        private ImageList ımageList2;
    }
}