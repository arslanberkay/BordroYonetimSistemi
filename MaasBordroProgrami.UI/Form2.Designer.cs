namespace MaasBordroProgrami.UI
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            mtxtCalismaSaati = new MaskedTextBox();
            cbDerece = new ComboBox();
            txtKadro = new TextBox();
            txtAdSoyad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            button1 = new Button();
            dgvPersonelYonetimi = new DataGridView();
            btnYeniPersonelKayit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonelYonetimi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtCalismaSaati);
            groupBox1.Controls.Add(cbDerece);
            groupBox1.Controls.Add(txtKadro);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(89, 60);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(479, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Yönetimi";
            // 
            // mtxtCalismaSaati
            // 
            mtxtCalismaSaati.Location = new Point(151, 163);
            mtxtCalismaSaati.Mask = "000";
            mtxtCalismaSaati.Name = "mtxtCalismaSaati";
            mtxtCalismaSaati.Size = new Size(203, 34);
            mtxtCalismaSaati.TabIndex = 3;
            mtxtCalismaSaati.ValidatingType = typeof(int);
            // 
            // cbDerece
            // 
            cbDerece.FormattingEnabled = true;
            cbDerece.Location = new Point(151, 120);
            cbDerece.Name = "cbDerece";
            cbDerece.Size = new Size(203, 36);
            cbDerece.TabIndex = 2;
            // 
            // txtKadro
            // 
            txtKadro.Location = new Point(151, 78);
            txtKadro.Name = "txtKadro";
            txtKadro.Size = new Size(203, 34);
            txtKadro.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(151, 36);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(203, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 163);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 0;
            label4.Text = "Çalışma Saati :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 0;
            label3.Text = "Derece :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 0;
            label2.Text = "Kadro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(593, 153);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 52);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(593, 211);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(119, 52);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(44, 46);
            button1.TabIndex = 1;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvPersonelYonetimi
            // 
            dgvPersonelYonetimi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonelYonetimi.Location = new Point(89, 300);
            dgvPersonelYonetimi.Name = "dgvPersonelYonetimi";
            dgvPersonelYonetimi.RowHeadersWidth = 51;
            dgvPersonelYonetimi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonelYonetimi.Size = new Size(928, 290);
            dgvPersonelYonetimi.TabIndex = 2;
            dgvPersonelYonetimi.CellClick += dgvPersonelYonetimi_CellClick;
            // 
            // btnYeniPersonelKayit
            // 
            btnYeniPersonelKayit.Location = new Point(593, 85);
            btnYeniPersonelKayit.Name = "btnYeniPersonelKayit";
            btnYeniPersonelKayit.Size = new Size(206, 57);
            btnYeniPersonelKayit.TabIndex = 3;
            btnYeniPersonelKayit.Text = "Yeni Personel Kayıt";
            btnYeniPersonelKayit.UseVisualStyleBackColor = true;
            btnYeniPersonelKayit.Click += btnYeniPersonelKayit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 630);
            Controls.Add(btnYeniPersonelKayit);
            Controls.Add(dgvPersonelYonetimi);
            Controls.Add(btnGuncelle);
            Controls.Add(button1);
            Controls.Add(btnSil);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonelYonetimi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSil;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuncelle;
        private Button button1;
        private DataGridView dgvPersonelYonetimi;
        private MaskedTextBox mtxtCalismaSaati;
        private ComboBox cbDerece;
        private TextBox txtAdSoyad;
        private Button btnYeniPersonelKayit;
        private TextBox txtKadro;
    }
}