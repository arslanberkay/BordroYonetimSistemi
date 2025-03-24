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
            button3 = new Button();
            SuspendLayout();
            // 
            // lstvTumPersonelBordrosu
            // 
            lstvTumPersonelBordrosu.BackColor = Color.WhiteSmoke;
            lstvTumPersonelBordrosu.Location = new Point(78, 113);
            lstvTumPersonelBordrosu.Margin = new Padding(4);
            lstvTumPersonelBordrosu.Name = "lstvTumPersonelBordrosu";
            lstvTumPersonelBordrosu.Size = new Size(1291, 362);
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
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.Gainsboro;
            btnPdfOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btnPdfOlustur.ImageIndex = 1;
            btnPdfOlustur.ImageList = ımageList2;
            btnPdfOlustur.Location = new Point(633, 498);
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
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.Gainsboro;
            btnExcelOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcelOlustur.ImageIndex = 2;
            btnExcelOlustur.ImageList = ımageList2;
            btnExcelOlustur.Location = new Point(871, 498);
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
            btnMailGonder.Location = new Point(1142, 498);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(227, 58);
            btnMailGonder.TabIndex = 1;
            btnMailGonder.Text = "Mail Gönder";
            btnMailGonder.UseVisualStyleBackColor = false;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1142, 60);
            button3.Name = "button3";
            button3.Size = new Size(227, 37);
            button3.TabIndex = 2;
            button3.Text = "150 Saat Altı Personel";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1417, 588);
            Controls.Add(button3);
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
        private Button button3;
    }
}