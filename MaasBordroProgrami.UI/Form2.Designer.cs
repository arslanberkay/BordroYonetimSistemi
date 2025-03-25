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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            ımageList2 = new ImageList(components);
            btnGuncelle = new Button();
            ımageList1 = new ImageList(components);
            btnAnaSayfayaGeriGec = new Button();
            dgvPersonelYonetimi = new DataGridView();
            pictureBox1 = new PictureBox();
            epAdSoyad = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonelYonetimi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epAdSoyad).BeginInit();
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
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(84, 60);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(384, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Yönetimi";
            // 
            // mtxtCalismaSaati
            // 
            mtxtCalismaSaati.Location = new Point(151, 163);
            mtxtCalismaSaati.Mask = "000";
            mtxtCalismaSaati.Name = "mtxtCalismaSaati";
            mtxtCalismaSaati.Size = new Size(192, 34);
            mtxtCalismaSaati.TabIndex = 3;
            mtxtCalismaSaati.ValidatingType = typeof(int);
            // 
            // cbDerece
            // 
            cbDerece.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDerece.FormattingEnabled = true;
            cbDerece.Location = new Point(151, 121);
            cbDerece.Name = "cbDerece";
            cbDerece.Size = new Size(192, 36);
            cbDerece.TabIndex = 2;
            // 
            // txtKadro
            // 
            txtKadro.Enabled = false;
            txtKadro.Location = new Point(151, 81);
            txtKadro.Name = "txtKadro";
            txtKadro.Size = new Size(192, 34);
            txtKadro.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.ForeColor = Color.Black;
            txtAdSoyad.Location = new Point(151, 36);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(192, 34);
            txtAdSoyad.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 163);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 0;
            label4.Text = "Çalışma Saati ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 0;
            label3.Text = "Derece ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "Kadro ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad ";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Gainsboro;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 0;
            btnSil.ImageList = ımageList2;
            btnSil.Location = new Point(98, 290);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "352303_delete_icon.png");
            ımageList2.Images.SetKeyName(1, "134221_refresh_reload_repeat_update_arrow_icon.png");
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Gainsboro;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageIndex = 1;
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(253, 290);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 40);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "9054423_bx_arrow_back_icon.png");
            ımageList1.Images.SetKeyName(1, "134221_refresh_reload_repeat_update_arrow_icon.png");
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.BackColor = Color.Gainsboro;
            btnAnaSayfayaGeriGec.FlatStyle = FlatStyle.Flat;
            btnAnaSayfayaGeriGec.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnaSayfayaGeriGec.ImageIndex = 0;
            btnAnaSayfayaGeriGec.ImageList = ımageList1;
            btnAnaSayfayaGeriGec.Location = new Point(30, 25);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(37, 35);
            btnAnaSayfayaGeriGec.TabIndex = 4;
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = false;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // dgvPersonelYonetimi
            // 
            dgvPersonelYonetimi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonelYonetimi.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonelYonetimi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonelYonetimi.ColumnHeadersHeight = 40;
            dgvPersonelYonetimi.GridColor = Color.LightGray;
            dgvPersonelYonetimi.Location = new Point(84, 347);
            dgvPersonelYonetimi.MultiSelect = false;
            dgvPersonelYonetimi.Name = "dgvPersonelYonetimi";
            dgvPersonelYonetimi.RowHeadersWidth = 30;
            dgvPersonelYonetimi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonelYonetimi.Size = new Size(854, 202);
            dgvPersonelYonetimi.TabIndex = 2;
            dgvPersonelYonetimi.CellClick += dgvPersonelYonetimi_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2530819_general_group_office_personal_relation_icon;
            pictureBox1.Location = new Point(487, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // epAdSoyad
            // 
            epAdSoyad.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1001, 595);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPersonelYonetimi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(btnSil);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonelYonetimi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)epAdSoyad).EndInit();
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
        private Button btnAnaSayfayaGeriGec;
        private DataGridView dgvPersonelYonetimi;
        private MaskedTextBox mtxtCalismaSaati;
        private ComboBox cbDerece;
        private TextBox txtAdSoyad;
        private TextBox txtKadro;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private PictureBox pictureBox1;
        private ErrorProvider epAdSoyad;
    }
}