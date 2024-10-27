namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            button1 = new Button();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label3 = new Label();
            MskNumara = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtSinav3 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            TxtSinav2 = new TextBox();
            TxtSinav1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            LblKalanSayisi = new Label();
            LblGecenSayisi = new Label();
            LblOrtalama = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(TxtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MskNumara);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(150, 180);
            button1.Name = "button1";
            button1.Size = new Size(141, 72);
            button1.TabIndex = 3;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(150, 131);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(141, 33);
            TxtSoyad.TabIndex = 2;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(150, 92);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(141, 33);
            TxtAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 134);
            label3.Name = "label3";
            label3.Size = new Size(77, 26);
            label3.TabIndex = 0;
            label3.Text = "Soyad:";
            // 
            // MskNumara
            // 
            MskNumara.Location = new Point(150, 53);
            MskNumara.Mask = "0000";
            MskNumara.Name = "MskNumara";
            MskNumara.Size = new Size(141, 33);
            MskNumara.TabIndex = 1;
            MskNumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 95);
            label2.Name = "label2";
            label2.Size = new Size(45, 26);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtSinav3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(TxtSinav2);
            groupBox2.Controls.Add(TxtSinav1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(389, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // TxtSinav3
            // 
            TxtSinav3.Location = new Point(150, 134);
            TxtSinav3.Name = "TxtSinav3";
            TxtSinav3.Size = new Size(141, 33);
            TxtSinav3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 137);
            label6.Name = "label6";
            label6.Size = new Size(93, 26);
            label6.TabIndex = 4;
            label6.Text = "Sınav 3:";
            // 
            // button2
            // 
            button2.Location = new Point(150, 180);
            button2.Name = "button2";
            button2.Size = new Size(125, 72);
            button2.TabIndex = 3;
            button2.Text = "Güncelle Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtSinav2
            // 
            TxtSinav2.Location = new Point(150, 95);
            TxtSinav2.Name = "TxtSinav2";
            TxtSinav2.Size = new Size(141, 33);
            TxtSinav2.TabIndex = 2;
            // 
            // TxtSinav1
            // 
            TxtSinav1.Location = new Point(150, 56);
            TxtSinav1.Name = "TxtSinav1";
            TxtSinav1.Size = new Size(141, 33);
            TxtSinav1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 98);
            label4.Name = "label4";
            label4.Size = new Size(94, 26);
            label4.TabIndex = 0;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 63);
            label5.Name = "label5";
            label5.Size = new Size(90, 26);
            label5.TabIndex = 0;
            label5.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LblKalanSayisi);
            groupBox3.Controls.Add(LblGecenSayisi);
            groupBox3.Controls.Add(LblOrtalama);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(769, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 174);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınıf Durumu";
            // 
            // LblKalanSayisi
            // 
            LblKalanSayisi.AutoSize = true;
            LblKalanSayisi.Location = new Point(278, 127);
            LblKalanSayisi.Name = "LblKalanSayisi";
            LblKalanSayisi.Size = new Size(42, 26);
            LblKalanSayisi.TabIndex = 5;
            LblKalanSayisi.Text = "00";
            // 
            // LblGecenSayisi
            // 
            LblGecenSayisi.AutoSize = true;
            LblGecenSayisi.Location = new Point(278, 86);
            LblGecenSayisi.Name = "LblGecenSayisi";
            LblGecenSayisi.Size = new Size(42, 26);
            LblGecenSayisi.TabIndex = 5;
            LblGecenSayisi.Text = "00";
            // 
            // LblOrtalama
            // 
            LblOrtalama.AutoSize = true;
            LblOrtalama.Location = new Point(278, 47);
            LblOrtalama.Name = "LblOrtalama";
            LblOrtalama.Size = new Size(42, 26);
            LblOrtalama.TabIndex = 5;
            LblOrtalama.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 127);
            label8.Name = "label8";
            label8.Size = new Size(266, 26);
            label8.TabIndex = 4;
            label8.Text = "Başarısız Öğrenci Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 86);
            label7.Name = "label7";
            label7.Size = new Size(252, 26);
            label7.TabIndex = 4;
            label7.Text = "Başarılı Öğrenci Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 47);
            label9.Name = "label9";
            label9.Size = new Size(186, 26);
            label9.TabIndex = 0;
            label9.Text = "Sınıf Ortalaması:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(16, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1100, 292);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1094, 260);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button3
            // 
            button3.Location = new Point(916, 223);
            button3.Name = "button3";
            button3.Size = new Size(153, 72);
            button3.TabIndex = 3;
            button3.Text = "Öğrencileri Listele";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(1128, 605);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Elephant", 11.999999F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label3;
        private MaskedTextBox MskNumara;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox TxtSinav2;
        private TextBox TxtSinav1;
        private Label label4;
        private Label label5;
        private TextBox TxtSinav3;
        private Label label6;
        private GroupBox groupBox3;
        private Label LblKalanSayisi;
        private Label LblGecenSayisi;
        private Label LblOrtalama;
        private Label label8;
        private Label label7;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button3;
    }
}