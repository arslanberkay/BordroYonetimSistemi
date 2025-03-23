namespace MaasBordroProgrami.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPersonelYonetimi = new Button();
            btnBordroHesaplama = new Button();
            btnTopluBordroGoruntule = new Button();
            btnUygulamadanCik = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(153, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 32);
            label1.TabIndex = 0;
            label1.Text = "Yapmak İstediğiniz İşlemi Seçin";
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.BackColor = Color.Gainsboro;
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.Location = new Point(182, 132);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(282, 58);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = false;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // btnBordroHesaplama
            // 
            btnBordroHesaplama.BackColor = Color.Gainsboro;
            btnBordroHesaplama.FlatStyle = FlatStyle.Flat;
            btnBordroHesaplama.Location = new Point(182, 208);
            btnBordroHesaplama.Name = "btnBordroHesaplama";
            btnBordroHesaplama.Size = new Size(282, 58);
            btnBordroHesaplama.TabIndex = 1;
            btnBordroHesaplama.Text = "Bordro Hesaplama";
            btnBordroHesaplama.UseVisualStyleBackColor = false;
            btnBordroHesaplama.Click += btnBordroHesaplama_Click;
            // 
            // btnTopluBordroGoruntule
            // 
            btnTopluBordroGoruntule.BackColor = Color.Gainsboro;
            btnTopluBordroGoruntule.FlatStyle = FlatStyle.Flat;
            btnTopluBordroGoruntule.Location = new Point(182, 283);
            btnTopluBordroGoruntule.Name = "btnTopluBordroGoruntule";
            btnTopluBordroGoruntule.Size = new Size(282, 58);
            btnTopluBordroGoruntule.TabIndex = 1;
            btnTopluBordroGoruntule.Text = "Toplu Bordro Görüntüle";
            btnTopluBordroGoruntule.UseVisualStyleBackColor = false;
            btnTopluBordroGoruntule.Click += btnTopluBordroGoruntule_Click;
            // 
            // btnUygulamadanCik
            // 
            btnUygulamadanCik.BackColor = Color.Gainsboro;
            btnUygulamadanCik.FlatStyle = FlatStyle.Flat;
            btnUygulamadanCik.Location = new Point(182, 359);
            btnUygulamadanCik.Name = "btnUygulamadanCik";
            btnUygulamadanCik.Size = new Size(282, 58);
            btnUygulamadanCik.TabIndex = 1;
            btnUygulamadanCik.Text = "Uygulamadan Çık";
            btnUygulamadanCik.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(694, 524);
            Controls.Add(btnUygulamadanCik);
            Controls.Add(btnBordroHesaplama);
            Controls.Add(btnTopluBordroGoruntule);
            Controls.Add(btnPersonelYonetimi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPersonelYonetimi;
        private Button btnBordroHesaplama;
        private Button btnTopluBordroGoruntule;
        private Button btnUygulamadanCik;
    }
}
