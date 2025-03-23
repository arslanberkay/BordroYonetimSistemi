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
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(559, 31);
            label1.TabIndex = 0;
            label1.Text = "Bordrosunu Hesaplamak İstediğiniz Personeli Seçiniz :";
            // 
            // cbPersonelAdSoyad
            // 
            cbPersonelAdSoyad.BackColor = Color.WhiteSmoke;
            cbPersonelAdSoyad.FormattingEnabled = true;
            cbPersonelAdSoyad.Location = new Point(613, 88);
            cbPersonelAdSoyad.Name = "cbPersonelAdSoyad";
            cbPersonelAdSoyad.Size = new Size(251, 33);
            cbPersonelAdSoyad.TabIndex = 1;
            // 
            // btnBordroHesapla
            // 
            btnBordroHesapla.BackColor = Color.Gainsboro;
            btnBordroHesapla.Location = new Point(613, 145);
            btnBordroHesapla.Name = "btnBordroHesapla";
            btnBordroHesapla.Size = new Size(253, 52);
            btnBordroHesapla.TabIndex = 2;
            btnBordroHesapla.Text = "Bordro Hesapla";
            btnBordroHesapla.UseVisualStyleBackColor = false;
            btnBordroHesapla.Click += btnBordroHesapla_Click;
            // 
            // lstvPersonelBordrosu
            // 
            lstvPersonelBordrosu.BackColor = Color.WhiteSmoke;
            lstvPersonelBordrosu.Location = new Point(47, 223);
            lstvPersonelBordrosu.Name = "lstvPersonelBordrosu";
            lstvPersonelBordrosu.Size = new Size(1334, 90);
            lstvPersonelBordrosu.TabIndex = 3;
            lstvPersonelBordrosu.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.BackColor = Color.Gainsboro;
            btnAnaSayfayaGeriGec.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnAnaSayfayaGeriGec.Location = new Point(47, 23);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(60, 44);
            btnAnaSayfayaGeriGec.TabIndex = 4;
            btnAnaSayfayaGeriGec.Text = "<";
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = false;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // btnJsonDosyaKaydet
            // 
            btnJsonDosyaKaydet.BackColor = Color.Gainsboro;
            btnJsonDosyaKaydet.Location = new Point(1031, 330);
            btnJsonDosyaKaydet.Name = "btnJsonDosyaKaydet";
            btnJsonDosyaKaydet.Size = new Size(350, 62);
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
    }
}