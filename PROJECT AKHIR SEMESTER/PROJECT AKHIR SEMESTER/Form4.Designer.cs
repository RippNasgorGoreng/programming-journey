namespace PROJECT_AKHIR_SEMESTER
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dataGridView2 = new DataGridView();
            Pertandingan = new DataGridViewTextBoxColumn();
            JenTikLih = new DataGridViewTextBoxColumn();
            JumPes = new DataGridViewTextBoxColumn();
            TotHar = new DataGridViewTextBoxColumn();
            label1 = new Label();
            JenTik = new DataGridViewTextBoxColumn();
            HarTik = new DataGridViewTextBoxColumn();
            Stoktik = new DataGridViewTextBoxColumn();
            button4 = new Button();
            buttontampil = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            buttonhapusrows = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            textBoxbayar = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Pertandingan, JenTikLih, JumPes, TotHar });
            dataGridView2.GridColor = SystemColors.Info;
            dataGridView2.Location = new Point(437, 327);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(557, 188);
            dataGridView2.TabIndex = 48;
            // 
            // Pertandingan
            // 
            Pertandingan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Pertandingan.DataPropertyName = "comboBox1.Text";
            Pertandingan.HeaderText = "Pertandingan :";
            Pertandingan.MinimumWidth = 6;
            Pertandingan.Name = "Pertandingan";
            Pertandingan.ReadOnly = true;
            Pertandingan.Width = 132;
            // 
            // JenTikLih
            // 
            JenTikLih.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            JenTikLih.HeaderText = "Jenis Tiket Yang Dipilih :";
            JenTikLih.MinimumWidth = 6;
            JenTikLih.Name = "JenTikLih";
            JenTikLih.ReadOnly = true;
            JenTikLih.Width = 133;
            // 
            // JumPes
            // 
            JumPes.HeaderText = "Jumlah Pesanan :";
            JumPes.MinimumWidth = 6;
            JumPes.Name = "JumPes";
            JumPes.ReadOnly = true;
            JumPes.Width = 125;
            // 
            // TotHar
            // 
            TotHar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TotHar.HeaderText = "Total Harga :";
            TotHar.MinimumWidth = 6;
            TotHar.Name = "TotHar";
            TotHar.ReadOnly = true;
            TotHar.Width = 113;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(249, 29);
            label1.Name = "label1";
            label1.Size = new Size(529, 23);
            label1.TabIndex = 42;
            label1.Text = "PENJUALAN TIKET MASUK STADION MOH SARENGAT";
            // 
            // JenTik
            // 
            JenTik.HeaderText = "Jenis Tiket";
            JenTik.MinimumWidth = 6;
            JenTik.Name = "JenTik";
            JenTik.ReadOnly = true;
            JenTik.Width = 125;
            // 
            // HarTik
            // 
            HarTik.HeaderText = "Harga Tiket";
            HarTik.MinimumWidth = 6;
            HarTik.Name = "HarTik";
            HarTik.ReadOnly = true;
            HarTik.Width = 125;
            // 
            // Stoktik
            // 
            Stoktik.HeaderText = "Stok tiket";
            Stoktik.MinimumWidth = 6;
            Stoktik.Name = "Stoktik";
            Stoktik.ReadOnly = true;
            Stoktik.Width = 125;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.download__1_;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(-4, -3);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 54;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttontampil
            // 
            buttontampil.ForeColor = SystemColors.ActiveCaptionText;
            buttontampil.Location = new Point(437, 292);
            buttontampil.Name = "buttontampil";
            buttontampil.Size = new Size(147, 29);
            buttontampil.TabIndex = 47;
            buttontampil.Text = "Tampilkan pesanan";
            buttontampil.UseVisualStyleBackColor = true;
            buttontampil.Click += buttontampil_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(437, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 208);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pemesanan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(194, 36);
            label7.Name = "label7";
            label7.Size = new Size(162, 17);
            label7.TabIndex = 8;
            label7.Text = "PERSIBAT VS PERSIP";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 33);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 1;
            label2.Text = "Pertandingan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 2;
            label3.Text = "Pilih tribun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(24, 132);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 3;
            label4.Text = "Jumlah Beli";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(194, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(195, 25);
            comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(194, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 25);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 65);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 45;
            label6.Text = "Informasi Tiket";
            // 
            // buttonhapusrows
            // 
            buttonhapusrows.Location = new Point(437, 521);
            buttonhapusrows.Name = "buttonhapusrows";
            buttonhapusrows.Size = new Size(207, 29);
            buttonhapusrows.TabIndex = 43;
            buttonhapusrows.Text = "Hapus pesanan terakhir";
            buttonhapusrows.UseVisualStyleBackColor = true;
            buttonhapusrows.Click += buttonhapusrows_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(900, 565);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 53;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(800, 565);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 52;
            button1.Text = "NEW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(14, 382);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 51;
            button3.Text = "Pesan";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBoxbayar
            // 
            textBoxbayar.Location = new Point(14, 349);
            textBoxbayar.Name = "textBoxbayar";
            textBoxbayar.Size = new Size(125, 27);
            textBoxbayar.TabIndex = 50;
            textBoxbayar.TextChanged += textBoxbayar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 314);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 49;
            label5.Text = "Pembayaran";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { JenTik, HarTik, Stoktik });
            dataGridView1.Location = new Point(14, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(404, 169);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(889, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_18_Nov_2025__05_50_38;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 600);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(buttontampil);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(buttonhapusrows);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBoxbayar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Pertandingan;
        private DataGridViewTextBoxColumn JenTikLih;
        private DataGridViewTextBoxColumn JumPes;
        private DataGridViewTextBoxColumn TotHar;
        private Label label1;
        private DataGridViewTextBoxColumn JenTik;
        private DataGridViewTextBoxColumn HarTik;
        private DataGridViewTextBoxColumn Stoktik;
        private Button button4;
        private Button buttontampil;
        private GroupBox groupBox1;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label6;
        private Button buttonhapusrows;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox textBoxbayar;
        private Label label5;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}