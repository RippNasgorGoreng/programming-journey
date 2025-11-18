namespace PROJECT_AKHIR_SEMESTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            cmbpilper = new ComboBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 21);
            label1.Name = "label1";
            label1.Size = new Size(628, 25);
            label1.TabIndex = 0;
            label1.Text = "PENJUALAN TIKET MASUK STADION MOH SARENGAT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(277, 71);
            label2.Name = "label2";
            label2.Size = new Size(389, 23);
            label2.TabIndex = 1;
            label2.Text = "PILIH PERTANDINGAN YANG TERSEDIA";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(354, 258);
            button1.Name = "button1";
            button1.Size = new Size(217, 29);
            button1.TabIndex = 2;
            button1.Text = "CEK DAN PESAN TIKET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbpilper
            // 
            cmbpilper.BackColor = Color.White;
            cmbpilper.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpilper.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbpilper.ForeColor = SystemColors.InfoText;
            cmbpilper.FormattingEnabled = true;
            cmbpilper.Location = new Point(325, 118);
            cmbpilper.Name = "cmbpilper";
            cmbpilper.Size = new Size(282, 31);
            cmbpilper.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(898, 559);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(833, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 107);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stadion_psbt__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 600);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(cmbpilper);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox cmbpilper;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
