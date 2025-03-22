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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // 
            // button2
            // 
            button2.Location = new Point(265, 546);
            button2.Name = "button2";
            button2.Size = new Size(349, 58);
            button2.TabIndex = 1;
            button2.Text = "PDF Oluştur";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(666, 546);
            button3.Name = "button3";
            button3.Size = new Size(349, 58);
            button3.TabIndex = 1;
            button3.Text = "EXCEL Oluştur";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1067, 546);
            button4.Name = "button4";
            button4.Size = new Size(349, 58);
            button4.TabIndex = 1;
            button4.Text = "Mail Gönder";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 721);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
    }
}