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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
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
            // button3
            // 
            button3.Location = new Point(182, 131);
            button3.Name = "button3";
            button3.Size = new Size(282, 58);
            button3.TabIndex = 1;
            button3.Text = "Personel Yönetimi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(182, 207);
            button1.Name = "button1";
            button1.Size = new Size(282, 58);
            button1.TabIndex = 1;
            button1.Text = "Bordro Hesaplama";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(182, 283);
            button2.Name = "button2";
            button2.Size = new Size(282, 58);
            button2.TabIndex = 1;
            button2.Text = "Toplu Bordro Görüntüle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(182, 359);
            button4.Name = "button4";
            button4.Size = new Size(282, 58);
            button4.TabIndex = 1;
            button4.Text = "Uygulamadan Çık";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 578);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}
