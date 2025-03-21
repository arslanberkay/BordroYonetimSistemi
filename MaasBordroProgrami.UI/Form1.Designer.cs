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
            label1.Location = new Point(153, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 32);
            label1.TabIndex = 0;
            label1.Text = "Yapmak İstediğiniz İşlemi Seçin";
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.Location = new Point(182, 131);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(282, 58);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = true;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // btnBordroHesaplama
            // 
            btnBordroHesaplama.Location = new Point(182, 207);
            btnBordroHesaplama.Name = "btnBordroHesaplama";
            btnBordroHesaplama.Size = new Size(282, 58);
            btnBordroHesaplama.TabIndex = 1;
            btnBordroHesaplama.Text = "Bordro Hesaplama";
            btnBordroHesaplama.UseVisualStyleBackColor = true;
            btnBordroHesaplama.Click += btnBordroHesaplama_Click;
            // 
            // btnTopluBordroGoruntule
            // 
            btnTopluBordroGoruntule.Location = new Point(182, 283);
            btnTopluBordroGoruntule.Name = "btnTopluBordroGoruntule";
            btnTopluBordroGoruntule.Size = new Size(282, 58);
            btnTopluBordroGoruntule.TabIndex = 1;
            btnTopluBordroGoruntule.Text = "Toplu Bordro Görüntüle";
            btnTopluBordroGoruntule.UseVisualStyleBackColor = true;
            // 
            // btnUygulamadanCik
            // 
            btnUygulamadanCik.Location = new Point(182, 359);
            btnUygulamadanCik.Name = "btnUygulamadanCik";
            btnUygulamadanCik.Size = new Size(282, 58);
            btnUygulamadanCik.TabIndex = 1;
            btnUygulamadanCik.Text = "Uygulamadan Çık";
            btnUygulamadanCik.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 578);
            Controls.Add(btnUygulamadanCik);
            Controls.Add(btnBordroHesaplama);
            Controls.Add(btnTopluBordroGoruntule);
            Controls.Add(btnPersonelYonetimi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
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
