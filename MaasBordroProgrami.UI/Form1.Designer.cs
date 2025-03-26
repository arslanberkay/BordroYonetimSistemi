﻿namespace MaasBordroProgrami.UI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPersonelYonetimi = new Button();
            ımageList1 = new ImageList(components);
            btnBordroHesaplama = new Button();
            ımageList2 = new ImageList(components);
            btnTopluBordroGoruntule = new Button();
            btnUygulamadanCik = new Button();
            btnYeniPersonelKayit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.BackColor = Color.Gainsboro;
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonelYonetimi.ImageKey = "1471083_general_group_office_personal_relation_icon.png";
            btnPersonelYonetimi.ImageList = ımageList1;
            btnPersonelYonetimi.Location = new Point(179, 200);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(291, 57);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = false;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "1564506_close_exit_logout_power_icon.png");
            ımageList1.Images.SetKeyName(1, "1471083_general_group_office_personal_relation_icon.png");
            ımageList1.Images.SetKeyName(2, "309050_add_group_users_business_human_icon.png");
            // 
            // btnBordroHesaplama
            // 
            btnBordroHesaplama.BackColor = Color.Gainsboro;
            btnBordroHesaplama.FlatStyle = FlatStyle.Flat;
            btnBordroHesaplama.ImageAlign = ContentAlignment.MiddleLeft;
            btnBordroHesaplama.ImageIndex = 1;
            btnBordroHesaplama.ImageList = ımageList2;
            btnBordroHesaplama.Location = new Point(179, 345);
            btnBordroHesaplama.Name = "btnBordroHesaplama";
            btnBordroHesaplama.Size = new Size(291, 57);
            btnBordroHesaplama.TabIndex = 1;
            btnBordroHesaplama.Text = "Bordro Hesaplama";
            btnBordroHesaplama.UseVisualStyleBackColor = false;
            btnBordroHesaplama.Click += btnBordroHesaplama_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "1564506_close_exit_logout_power_icon.png");
            ımageList2.Images.SetKeyName(1, "309097_calculator_calculation_finance_financial_icon.png");
            // 
            // btnTopluBordroGoruntule
            // 
            btnTopluBordroGoruntule.BackColor = Color.Gainsboro;
            btnTopluBordroGoruntule.FlatStyle = FlatStyle.Flat;
            btnTopluBordroGoruntule.Location = new Point(179, 418);
            btnTopluBordroGoruntule.Name = "btnTopluBordroGoruntule";
            btnTopluBordroGoruntule.Size = new Size(291, 57);
            btnTopluBordroGoruntule.TabIndex = 1;
            btnTopluBordroGoruntule.Text = "Toplu Bordro Görüntüle";
            btnTopluBordroGoruntule.UseVisualStyleBackColor = false;
            btnTopluBordroGoruntule.Click += btnTopluBordroGoruntule_Click;
            // 
            // btnUygulamadanCik
            // 
            btnUygulamadanCik.BackColor = Color.Gainsboro;
            btnUygulamadanCik.FlatStyle = FlatStyle.Flat;
            btnUygulamadanCik.ImageAlign = ContentAlignment.MiddleLeft;
            btnUygulamadanCik.ImageIndex = 0;
            btnUygulamadanCik.ImageList = ımageList2;
            btnUygulamadanCik.Location = new Point(179, 491);
            btnUygulamadanCik.Name = "btnUygulamadanCik";
            btnUygulamadanCik.Size = new Size(291, 57);
            btnUygulamadanCik.TabIndex = 1;
            btnUygulamadanCik.Text = "Uygulamadan Çık";
            btnUygulamadanCik.UseVisualStyleBackColor = false;
            btnUygulamadanCik.Click += btnUygulamadanCik_Click;
            // 
            // btnYeniPersonelKayit
            // 
            btnYeniPersonelKayit.BackColor = Color.Gainsboro;
            btnYeniPersonelKayit.FlatStyle = FlatStyle.Flat;
            btnYeniPersonelKayit.ImageAlign = ContentAlignment.MiddleLeft;
            btnYeniPersonelKayit.ImageIndex = 2;
            btnYeniPersonelKayit.ImageList = ımageList1;
            btnYeniPersonelKayit.Location = new Point(179, 273);
            btnYeniPersonelKayit.Name = "btnYeniPersonelKayit";
            btnYeniPersonelKayit.Size = new Size(291, 57);
            btnYeniPersonelKayit.TabIndex = 4;
            btnYeniPersonelKayit.Text = "Personel Kayıt";
            btnYeniPersonelKayit.UseVisualStyleBackColor = false;
            btnYeniPersonelKayit.Click += btnYeniPersonelKayit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3592856_general_group_office_personal_relation_icon;
            pictureBox1.Location = new Point(204, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(598, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(655, 604);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnYeniPersonelKayit);
            Controls.Add(btnUygulamadanCik);
            Controls.Add(btnBordroHesaplama);
            Controls.Add(btnTopluBordroGoruntule);
            Controls.Add(btnPersonelYonetimi);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPersonelYonetimi;
        private Button btnBordroHesaplama;
        private Button btnTopluBordroGoruntule;
        private Button btnUygulamadanCik;
        private Button btnYeniPersonelKayit;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private PictureBox pictureBox2;
    }
}
