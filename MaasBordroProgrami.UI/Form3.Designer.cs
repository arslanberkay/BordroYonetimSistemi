namespace MaasBordroProgrami.UI
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            cbPersonelKadro = new ComboBox();
            txtPersonelAdSoyad = new TextBox();
            label2 = new Label();
            btnPersonelEkle = new Button();
            btnPersonelYonetimSayfasinaGeriGec = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPersonelKadro);
            groupBox1.Controls.Add(txtPersonelAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(73, 66);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(361, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // cbPersonelKadro
            // 
            cbPersonelKadro.FormattingEnabled = true;
            cbPersonelKadro.Location = new Point(140, 91);
            cbPersonelKadro.Name = "cbPersonelKadro";
            cbPersonelKadro.Size = new Size(189, 36);
            cbPersonelKadro.TabIndex = 2;
            // 
            // txtPersonelAdSoyad
            // 
            txtPersonelAdSoyad.Location = new Point(140, 42);
            txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            txtPersonelAdSoyad.Size = new Size(189, 34);
            txtPersonelAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 0;
            label2.Text = "Kadro :";
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.Location = new Point(73, 228);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(336, 57);
            btnPersonelEkle.TabIndex = 1;
            btnPersonelEkle.Text = "Personel Ekle";
            btnPersonelEkle.UseVisualStyleBackColor = true;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnPersonelYonetimSayfasinaGeriGec
            // 
            btnPersonelYonetimSayfasinaGeriGec.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPersonelYonetimSayfasinaGeriGec.Location = new Point(22, 21);
            btnPersonelYonetimSayfasinaGeriGec.Name = "btnPersonelYonetimSayfasinaGeriGec";
            btnPersonelYonetimSayfasinaGeriGec.Size = new Size(44, 46);
            btnPersonelYonetimSayfasinaGeriGec.TabIndex = 2;
            btnPersonelYonetimSayfasinaGeriGec.Text = "<";
            btnPersonelYonetimSayfasinaGeriGec.UseVisualStyleBackColor = true;
            btnPersonelYonetimSayfasinaGeriGec.Click += btnPersonelYonetimSayfasinaGeriGec_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 315);
            Controls.Add(btnPersonelYonetimSayfasinaGeriGec);
            Controls.Add(btnPersonelEkle);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnPersonelEkle;
        private ComboBox cbPersonelKadro;
        private TextBox txtPersonelAdSoyad;
        private Button btnPersonelYonetimSayfasinaGeriGec;
    }
}