namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblSinav1 = new Label();
            LblSinav2 = new Label();
            LblSinav3 = new Label();
            LblAdSoyad = new Label();
            LblNumara = new Label();
            label11 = new Label();
            LblOrtalama = new Label();
            label13 = new Label();
            LblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 83);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 1;
            label2.Text = "Numara:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 132);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 2;
            label3.Text = "Not 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 176);
            label4.Name = "label4";
            label4.Size = new Size(75, 26);
            label4.TabIndex = 3;
            label4.Text = "Not 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 217);
            label5.Name = "label5";
            label5.Size = new Size(74, 26);
            label5.TabIndex = 4;
            label5.Text = "Not 3:";
            // 
            // LblSinav1
            // 
            LblSinav1.AutoSize = true;
            LblSinav1.Location = new Point(171, 132);
            LblSinav1.Name = "LblSinav1";
            LblSinav1.Size = new Size(42, 26);
            LblSinav1.TabIndex = 2;
            LblSinav1.Text = "00";
            // 
            // LblSinav2
            // 
            LblSinav2.AutoSize = true;
            LblSinav2.Location = new Point(171, 176);
            LblSinav2.Name = "LblSinav2";
            LblSinav2.Size = new Size(42, 26);
            LblSinav2.TabIndex = 2;
            LblSinav2.Text = "00";
            // 
            // LblSinav3
            // 
            LblSinav3.AutoSize = true;
            LblSinav3.Location = new Point(170, 217);
            LblSinav3.Name = "LblSinav3";
            LblSinav3.Size = new Size(42, 26);
            LblSinav3.TabIndex = 2;
            LblSinav3.Text = "00";
            LblSinav3.Click += label8_Click;
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(171, 34);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(79, 26);
            LblAdSoyad.TabIndex = 2;
            LblAdSoyad.Text = "NULL";
            LblAdSoyad.Click += label8_Click;
            // 
            // LblNumara
            // 
            LblNumara.AutoSize = true;
            LblNumara.Location = new Point(171, 83);
            LblNumara.Name = "LblNumara";
            LblNumara.Size = new Size(72, 26);
            LblNumara.TabIndex = 2;
            LblNumara.Text = "0000";
            LblNumara.Click += label8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 34);
            label11.Name = "label11";
            label11.Size = new Size(116, 26);
            label11.TabIndex = 2;
            label11.Text = "Ortalama:";
            label11.Click += label8_Click;
            // 
            // LblOrtalama
            // 
            LblOrtalama.AutoSize = true;
            LblOrtalama.Location = new Point(510, 34);
            LblOrtalama.Name = "LblOrtalama";
            LblOrtalama.Size = new Size(42, 26);
            LblOrtalama.TabIndex = 2;
            LblOrtalama.Text = "00";
            LblOrtalama.Click += label8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(412, 83);
            label13.Name = "label13";
            label13.Size = new Size(92, 26);
            label13.TabIndex = 2;
            label13.Text = "Durum:";
            label13.Click += label8_Click;
            // 
            // LblDurum
            // 
            LblDurum.AutoSize = true;
            LblDurum.Location = new Point(510, 83);
            LblDurum.Name = "LblDurum";
            LblDurum.Size = new Size(79, 26);
            LblDurum.TabIndex = 2;
            LblDurum.Text = "NULL";
            LblDurum.Click += label8_Click;
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(826, 283);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblNumara);
            Controls.Add(LblDurum);
            Controls.Add(LblAdSoyad);
            Controls.Add(label13);
            Controls.Add(LblOrtalama);
            Controls.Add(label11);
            Controls.Add(LblSinav3);
            Controls.Add(LblSinav2);
            Controls.Add(LblSinav1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Detay";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblSinav1;
        private Label LblSinav2;
        private Label LblSinav3;
        private Label LblAdSoyad;
        private Label LblNumara;
        private Label label11;
        private Label LblOrtalama;
        private Label label13;
        private Label LblDurum;
    }
}