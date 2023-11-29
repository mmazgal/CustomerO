namespace CustomerO
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxSehir = new TextBox();
            textBoxKrediyeUygunMu = new TextBox();
            textBoxAylikGelir = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            textBoxMusteriID = new TextBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(19, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 337);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(955, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxSehir);
            panel2.Controls.Add(textBoxKrediyeUygunMu);
            panel2.Controls.Add(textBoxAylikGelir);
            panel2.Controls.Add(textBoxSoyad);
            panel2.Controls.Add(textBoxAd);
            panel2.Controls.Add(textBoxMusteriID);
            panel2.Location = new Point(19, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 165);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(715, 103);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(715, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(715, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 107);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Şehir :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 62);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 10;
            label5.Text = "Krediye Uygun Mu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 19);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Aylık Gelir :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 107);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 62);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 7;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Müşteri Id :";
            // 
            // textBoxSehir
            // 
            textBoxSehir.Location = new Point(486, 100);
            textBoxSehir.Name = "textBoxSehir";
            textBoxSehir.Size = new Size(125, 27);
            textBoxSehir.TabIndex = 5;
            // 
            // textBoxKrediyeUygunMu
            // 
            textBoxKrediyeUygunMu.Enabled = false;
            textBoxKrediyeUygunMu.Location = new Point(486, 55);
            textBoxKrediyeUygunMu.Name = "textBoxKrediyeUygunMu";
            textBoxKrediyeUygunMu.Size = new Size(125, 27);
            textBoxKrediyeUygunMu.TabIndex = 4;
            // 
            // textBoxAylikGelir
            // 
            textBoxAylikGelir.Location = new Point(486, 16);
            textBoxAylikGelir.Name = "textBoxAylikGelir";
            textBoxAylikGelir.Size = new Size(125, 27);
            textBoxAylikGelir.TabIndex = 3;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(160, 100);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(125, 27);
            textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(160, 55);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(125, 27);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxMusteriID
            // 
            textBoxMusteriID.Enabled = false;
            textBoxMusteriID.Location = new Point(160, 12);
            textBoxMusteriID.Name = "textBoxMusteriID";
            textBoxMusteriID.Size = new Size(125, 27);
            textBoxMusteriID.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(833, 19);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxSehir;
        private TextBox textBoxKrediyeUygunMu;
        private TextBox textBoxAylikGelir;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private TextBox textBoxMusteriID;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
