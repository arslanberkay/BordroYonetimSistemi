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
            btnMailGonderimGecis = new Button();
            btnAzCalisanPersonel = new Button();
            btnTumPersoneller = new Button();
            btnAlfabetikSiralama = new Button();
            ımageList3 = new ImageList(components);
            btnCalismaSaatiSiralama = new Button();
            lblBildirim = new Label();
            btnMailGonderme = new Button();
            chkExcel = new CheckBox();
            chkPdf = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pnlMailGonderimAlani = new Panel();
            btnTumPersonelBordrosuSayfasinaGec = new Button();
            ımageList4 = new ImageList(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            pnlMailGonderimAlani.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // btnMailGonderimGecis
            // 
            btnMailGonderimGecis.BackColor = Color.Gainsboro;
            btnMailGonderimGecis.ImageAlign = ContentAlignment.MiddleLeft;
            btnMailGonderimGecis.ImageKey = "4202011_email_gmail_mail_logo_social_icon.png";
            btnMailGonderimGecis.ImageList = ımageList2;
            btnMailGonderimGecis.Location = new Point(1174, 497);
            btnMailGonderimGecis.Name = "btnMailGonderimGecis";
            btnMailGonderimGecis.Size = new Size(227, 58);
            btnMailGonderimGecis.TabIndex = 1;
            btnMailGonderimGecis.Text = "Mail Gönder";
            btnMailGonderimGecis.UseVisualStyleBackColor = false;
            btnMailGonderimGecis.Click += btnMailGonderimGecis_Click;
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
            btnCalismaSaatiSiralama.ForeColor = SystemColors.ControlLight;
            btnCalismaSaatiSiralama.ImageIndex = 2;
            btnCalismaSaatiSiralama.ImageList = ımageList3;
            btnCalismaSaatiSiralama.Location = new Point(635, 60);
            btnCalismaSaatiSiralama.Name = "btnCalismaSaatiSiralama";
            btnCalismaSaatiSiralama.Size = new Size(50, 39);
            btnCalismaSaatiSiralama.TabIndex = 5;
            btnCalismaSaatiSiralama.UseVisualStyleBackColor = true;
            btnCalismaSaatiSiralama.Click += btnCalismaSaatiSiralama_Click;
            // 
            // lblBildirim
            // 
            lblBildirim.Location = new Point(169, 15);
            lblBildirim.Name = "lblBildirim";
            lblBildirim.Size = new Size(816, 29);
            lblBildirim.TabIndex = 6;
            // 
            // btnMailGonderme
            // 
            btnMailGonderme.BackColor = Color.Gainsboro;
            btnMailGonderme.ForeColor = Color.Black;
            btnMailGonderme.ImageAlign = ContentAlignment.MiddleLeft;
            btnMailGonderme.ImageKey = "4202011_email_gmail_mail_logo_social_icon.png";
            btnMailGonderme.ImageList = ımageList2;
            btnMailGonderme.Location = new Point(25, 140);
            btnMailGonderme.Name = "btnMailGonderme";
            btnMailGonderme.Size = new Size(340, 56);
            btnMailGonderme.TabIndex = 9;
            btnMailGonderme.Text = "Mail Gönder";
            btnMailGonderme.UseVisualStyleBackColor = false;
            btnMailGonderme.Click += btnMailGonderme_Click;
            // 
            // chkExcel
            // 
            chkExcel.AutoSize = true;
            chkExcel.ForeColor = Color.White;
            chkExcel.Location = new Point(95, 101);
            chkExcel.Name = "chkExcel";
            chkExcel.Size = new Size(87, 32);
            chkExcel.TabIndex = 2;
            chkExcel.Text = "EXCEL";
            chkExcel.UseVisualStyleBackColor = true;
            // 
            // chkPdf
            // 
            chkPdf.AutoSize = true;
            chkPdf.ForeColor = Color.White;
            chkPdf.Location = new Point(25, 99);
            chkPdf.Name = "chkPdf";
            chkPdf.Size = new Size(69, 32);
            chkPdf.TabIndex = 2;
            chkPdf.Text = "PDF";
            chkPdf.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Mail Adresi";
            // 
            // pnlMailGonderimAlani
            // 
            pnlMailGonderimAlani.Controls.Add(groupBox1);
            pnlMailGonderimAlani.Controls.Add(btnTumPersonelBordrosuSayfasinaGec);
            pnlMailGonderimAlani.Location = new Point(955, 413);
            pnlMailGonderimAlani.Name = "pnlMailGonderimAlani";
            pnlMailGonderimAlani.Size = new Size(447, 252);
            pnlMailGonderimAlani.TabIndex = 8;
            // 
            // btnTumPersonelBordrosuSayfasinaGec
            // 
            btnTumPersonelBordrosuSayfasinaGec.BackColor = Color.Gainsboro;
            btnTumPersonelBordrosuSayfasinaGec.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTumPersonelBordrosuSayfasinaGec.ImageIndex = 0;
            btnTumPersonelBordrosuSayfasinaGec.ImageList = ımageList4;
            btnTumPersonelBordrosuSayfasinaGec.Location = new Point(7, 7);
            btnTumPersonelBordrosuSayfasinaGec.Name = "btnTumPersonelBordrosuSayfasinaGec";
            btnTumPersonelBordrosuSayfasinaGec.Size = new Size(25, 25);
            btnTumPersonelBordrosuSayfasinaGec.TabIndex = 9;
            btnTumPersonelBordrosuSayfasinaGec.UseVisualStyleBackColor = false;
            btnTumPersonelBordrosuSayfasinaGec.Click += btnTumPersonelBordrosuSayfasinaGec_Click;
            // 
            // ımageList4
            // 
            ımageList4.ColorDepth = ColorDepth.Depth32Bit;
            ımageList4.ImageStream = (ImageListStreamer)resources.GetObject("ımageList4.ImageStream");
            ımageList4.TransparentColor = Color.Transparent;
            ımageList4.Images.SetKeyName(0, "9054423_bx_arrow_back_icon.png");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkExcel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnMailGonderme);
            groupBox1.Controls.Add(chkPdf);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(38, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 211);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mail Gönderim İşlemleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 73);
            label2.Name = "label2";
            label2.Size = new Size(230, 28);
            label2.TabIndex = 0;
            label2.Text = "Gönderilecek Dosya Türü\r\n";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1447, 668);
            Controls.Add(pnlMailGonderimAlani);
            Controls.Add(lblBildirim);
            Controls.Add(btnCalismaSaatiSiralama);
            Controls.Add(btnAlfabetikSiralama);
            Controls.Add(btnTumPersoneller);
            Controls.Add(btnAzCalisanPersonel);
            Controls.Add(btnMailGonderimGecis);
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
            pnlMailGonderimAlani.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lstvTumPersonelBordrosu;
        private Button btnAnaSayfayaGeriGec;
        private Button btnPdfOlustur;
        private Button btnExcelOlustur;
        private Button btnMailGonderimGecis;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private Button btnAzCalisanPersonel;
        private Button btnTumPersoneller;
        private Button btnAlfabetikSiralama;
        private ImageList ımageList3;
        private Button btnCalismaSaatiSiralama;
        private Label lblBildirim;
        private CheckBox chkPdf;
        private TextBox textBox1;
        private Label label1;
        private Panel pnlMailGonderimAlani;
        private Button btnTumPersonelBordrosuSayfasinaGec;
        private ImageList ımageList4;
        private CheckBox chkExcel;
        private Button btnMailGonderme;
        private GroupBox groupBox1;
        private Label label2;
    }
}