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
            label1 = new Label();
            cbPersonelAdSoyad = new ComboBox();
            btnBordroHesapla = new Button();
            lstvPersonelBordrosu = new ListView();
            btnAnaSayfayaGeriGec = new Button();
            btnJsonDosyaKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 25);
            label1.TabIndex = 0;
            label1.Text = "Bordrosunu Hesaplamak İstediğiniz Personeli Seçiniz :";
            // 
            // cbPersonelAdSoyad
            // 
            cbPersonelAdSoyad.FormattingEnabled = true;
            cbPersonelAdSoyad.Location = new Point(538, 83);
            cbPersonelAdSoyad.Name = "cbPersonelAdSoyad";
            cbPersonelAdSoyad.Size = new Size(251, 33);
            cbPersonelAdSoyad.TabIndex = 1;
            // 
            // btnBordroHesapla
            // 
            btnBordroHesapla.Location = new Point(538, 140);
            btnBordroHesapla.Name = "btnBordroHesapla";
            btnBordroHesapla.Size = new Size(253, 52);
            btnBordroHesapla.TabIndex = 2;
            btnBordroHesapla.Text = "Bordro Hesapla";
            btnBordroHesapla.UseVisualStyleBackColor = true;
            btnBordroHesapla.Click += btnBordroHesapla_Click;
            // 
            // lstvPersonelBordrosu
            // 
            lstvPersonelBordrosu.Location = new Point(47, 223);
            lstvPersonelBordrosu.Name = "lstvPersonelBordrosu";
            lstvPersonelBordrosu.Size = new Size(1334, 90);
            lstvPersonelBordrosu.TabIndex = 3;
            lstvPersonelBordrosu.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnAnaSayfayaGeriGec.Location = new Point(47, 23);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(60, 41);
            btnAnaSayfayaGeriGec.TabIndex = 4;
            btnAnaSayfayaGeriGec.Text = "<";
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = true;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // btnJsonDosyaKaydet
            // 
            btnJsonDosyaKaydet.Location = new Point(1031, 330);
            btnJsonDosyaKaydet.Name = "btnJsonDosyaKaydet";
            btnJsonDosyaKaydet.Size = new Size(350, 62);
            btnJsonDosyaKaydet.TabIndex = 2;
            btnJsonDosyaKaydet.Text = "Dosya Olarak Kaydet";
            btnJsonDosyaKaydet.UseVisualStyleBackColor = true;
            btnJsonDosyaKaydet.Click += btnJsonDosyaKaydet_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 426);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(lstvPersonelBordrosu);
            Controls.Add(btnJsonDosyaKaydet);
            Controls.Add(btnBordroHesapla);
            Controls.Add(cbPersonelAdSoyad);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "Form4";
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
    }
}