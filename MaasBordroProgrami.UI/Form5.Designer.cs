namespace MaasBordroProgrami.UI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lstvTumPersonelBordrosu = new ListView();
            btnAnaSayfayaGeriGec = new Button();
            ımageList1 = new ImageList(components);
            btnPdfOlustur = new Button();
            ımageList2 = new ImageList(components);
            btnExcelOlustur = new Button();
            btnMailGonder = new Button();
            btnAzCalisanPersonel = new Button();
            btnTumPersoneller = new Button();
            btnAlfabetikSiralama = new Button();
            ımageList3 = new ImageList(components);
            btnCalismaSaatiSiralama = new Button();
            SuspendLayout();
            // 
            // lstvTumPersonelBordrosu
            // 
            lstvTumPersonelBordrosu.BackColor = Color.WhiteSmoke;
            lstvTumPersonelBordrosu.Location = new Point(78, 113);
            lstvTumPersonelBordrosu.Margin = new Padding(4);
            lstvTumPersonelBordrosu.Name = "lstvTumPersonelBordrosu";
            lstvTumPersonelBordrosu.Size = new Size(1324, 362);
            lstvTumPersonelBordrosu.TabIndex = 0;
            lstvTumPersonelBordrosu.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.BackColor = Color.Gainsboro;
            btnAnaSayfayaGeriGec.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAnaSayfayaGeriGec.ImageIndex = 0;
            btnAnaSayfayaGeriGec.ImageList = ımageList1;
            btnAnaSayfayaGeriGec.Location = new Point(30, 25);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(37, 35);
            btnAnaSayfayaGeriGec.TabIndex = 1;
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = false;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "9054423_bx_arrow_back_icon.png");
            ımageList1.Images.SetKeyName(1, "11615496_align_alphabetic_sort_order_icon.png");
            ımageList1.Images.SetKeyName(2, "11515530_align_alphabetic_sort_order_icon.png");
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.Gainsboro;
            btnPdfOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btnPdfOlustur.ImageIndex = 1;
            btnPdfOlustur.ImageList = ımageList2;
            btnPdfOlustur.Location = new Point(683, 497);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(214, 58);
            btnPdfOlustur.TabIndex = 1;
            btnPdfOlustur.Text = "PDF Oluştur";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "4202011_email_gmail_mail_logo_social_icon.png");
            ımageList2.Images.SetKeyName(1, "4518956_adobe_file_pdf_type_icon.png");
            ımageList2.Images.SetKeyName(2, "6296676_excel_microsoft_office_office365_icon.png");
            ımageList2.Images.SetKeyName(3, "11515530_align_alphabetic_sort_order_icon.png");
            ımageList2.Images.SetKeyName(4, "11615496_align_alphabetic_sort_order_icon.png");
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.Gainsboro;
            btnExcelOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcelOlustur.ImageIndex = 2;
            btnExcelOlustur.ImageList = ımageList2;
            btnExcelOlustur.Location = new Point(913, 497);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(245, 58);
            btnExcelOlustur.TabIndex = 1;
            btnExcelOlustur.Text = "EXCEL Oluştur";
            btnExcelOlustur.UseVisualStyleBackColor = false;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnMailGonder
            // 
            btnMailGonder.BackColor = Color.Gainsboro;
            btnMailGonder.ImageAlign = ContentAlignment.MiddleLeft;
            btnMailGonder.ImageKey = "4202011_email_gmail_mail_logo_social_icon.png";
            btnMailGonder.ImageList = ımageList2;
            btnMailGonder.Location = new Point(1174, 497);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(227, 58);
            btnMailGonder.TabIndex = 1;
            btnMailGonder.Text = "Mail Gönder";
            btnMailGonder.UseVisualStyleBackColor = false;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // btnAzCalisanPersonel
            // 
            btnAzCalisanPersonel.BackColor = Color.Gainsboro;
            btnAzCalisanPersonel.Location = new Point(1175, 60);
            btnAzCalisanPersonel.Name = "btnAzCalisanPersonel";
            btnAzCalisanPersonel.Size = new Size(227, 37);
            btnAzCalisanPersonel.TabIndex = 2;
            btnAzCalisanPersonel.Text = "150 Saat Altı Personel";
            btnAzCalisanPersonel.UseVisualStyleBackColor = false;
            btnAzCalisanPersonel.Click += btnAzCalisanPersonel_Click;
            // 
            // btnTumPersoneller
            // 
            btnTumPersoneller.BackColor = Color.Gainsboro;
            btnTumPersoneller.Location = new Point(912, 60);
            btnTumPersoneller.Name = "btnTumPersoneller";
            btnTumPersoneller.Size = new Size(245, 37);
            btnTumPersoneller.TabIndex = 3;
            btnTumPersoneller.Text = "Tüm Personeller";
            btnTumPersoneller.UseVisualStyleBackColor = false;
            btnTumPersoneller.Click += btnTumPersoneller_Click;
            // 
            // btnAlfabetikSiralama
            // 
            btnAlfabetikSiralama.BackColor = Color.Gainsboro;
            btnAlfabetikSiralama.ImageKey = "11615496_align_alphabetic_sort_order_icon.png";
            btnAlfabetikSiralama.ImageList = ımageList3;
            btnAlfabetikSiralama.Location = new Point(30, 113);
            btnAlfabetikSiralama.Name = "btnAlfabetikSiralama";
            btnAlfabetikSiralama.Size = new Size(37, 40);
            btnAlfabetikSiralama.TabIndex = 4;
            btnAlfabetikSiralama.UseVisualStyleBackColor = false;
            btnAlfabetikSiralama.Click += btnAlfabetikSiralama_Click;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "11615496_align_alphabetic_sort_order_icon.png");
            ımageList3.Images.SetKeyName(1, "11515530_align_alphabetic_sort_order_icon.png");
            ımageList3.Images.SetKeyName(2, "1542257_sort_arrows_ascending_descending_match_icon.png");
            // 
            // btnCalismaSaatiSiralama
            // 
            btnCalismaSaatiSiralama.ImageIndex = 2;
            btnCalismaSaatiSiralama.ImageList = ımageList3;
            btnCalismaSaatiSiralama.Location = new Point(703, 60);
            btnCalismaSaatiSiralama.Name = "btnCalismaSaatiSiralama";
            btnCalismaSaatiSiralama.Size = new Size(50, 39);
            btnCalismaSaatiSiralama.TabIndex = 5;
            btnCalismaSaatiSiralama.UseVisualStyleBackColor = true;
            btnCalismaSaatiSiralama.Click += btnCalismaSaatiSiralama_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1450, 597);
            Controls.Add(btnCalismaSaatiSiralama);
            Controls.Add(btnAlfabetikSiralama);
            Controls.Add(btnTumPersoneller);
            Controls.Add(btnAzCalisanPersonel);
            Controls.Add(btnMailGonder);
            Controls.Add(btnExcelOlustur);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(lstvTumPersonelBordrosu);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstvTumPersonelBordrosu;
        private Button btnAnaSayfayaGeriGec;
        private Button btnPdfOlustur;
        private Button btnExcelOlustur;
        private Button btnMailGonder;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private Button btnAzCalisanPersonel;
        private Button btnTumPersoneller;
        private Button btnAlfabetikSiralama;
        private ImageList ımageList3;
        private Button btnCalismaSaatiSiralama;
    }
}