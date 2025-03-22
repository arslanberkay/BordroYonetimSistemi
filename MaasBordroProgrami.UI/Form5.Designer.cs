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
            lstvTumPersonelBordrosu = new ListView();
            btnAnaSayfayaGeriGec = new Button();
            btnPdfOlustur = new Button();
            btnExcelOlustur = new Button();
            btnMailGonder = new Button();
            SuspendLayout();
            // 
            // lstvTumPersonelBordrosu
            // 
            lstvTumPersonelBordrosu.Location = new Point(58, 95);
            lstvTumPersonelBordrosu.Margin = new Padding(4);
            lstvTumPersonelBordrosu.Name = "lstvTumPersonelBordrosu";
            lstvTumPersonelBordrosu.Size = new Size(1355, 420);
            lstvTumPersonelBordrosu.TabIndex = 0;
            lstvTumPersonelBordrosu.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnaSayfayaGeriGec
            // 
            btnAnaSayfayaGeriGec.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAnaSayfayaGeriGec.Location = new Point(58, 26);
            btnAnaSayfayaGeriGec.Name = "btnAnaSayfayaGeriGec";
            btnAnaSayfayaGeriGec.Size = new Size(62, 44);
            btnAnaSayfayaGeriGec.TabIndex = 1;
            btnAnaSayfayaGeriGec.Text = "<";
            btnAnaSayfayaGeriGec.UseVisualStyleBackColor = true;
            btnAnaSayfayaGeriGec.Click += btnAnaSayfayaGeriGec_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.Location = new Point(265, 546);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(349, 58);
            btnPdfOlustur.TabIndex = 1;
            btnPdfOlustur.Text = "PDF Oluştur";
            btnPdfOlustur.UseVisualStyleBackColor = true;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.Location = new Point(666, 546);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(349, 58);
            btnExcelOlustur.TabIndex = 1;
            btnExcelOlustur.Text = "EXCEL Oluştur";
            btnExcelOlustur.UseVisualStyleBackColor = true;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnMailGonder
            // 
            btnMailGonder.Location = new Point(1067, 546);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(349, 58);
            btnMailGonder.TabIndex = 1;
            btnMailGonder.Text = "Mail Gönder";
            btnMailGonder.UseVisualStyleBackColor = true;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 721);
            Controls.Add(btnMailGonder);
            Controls.Add(btnExcelOlustur);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnAnaSayfayaGeriGec);
            Controls.Add(lstvTumPersonelBordrosu);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form5";
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
    }
}