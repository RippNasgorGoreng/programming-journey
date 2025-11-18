namespace PROJECT_AKHIR_SEMESTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbpilper.Items.Add("Persibat vs Persika 20-11-2025");
            cmbpilper.Items.Add("Persibat vs Persefteam 26-11-2025");
            cmbpilper.Items.Add("Persibat vs Persip 31-11-2025");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbpilper.Text == "Persibat vs Persika 20-11-2025")
            {
                FormP1 Form2 = new FormP1();
                Form2.Show();
                this.Hide();
            }
            else if (cmbpilper.Text == "Persibat vs Persefteam 26-11-2025")
            {
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
            }
            else if (cmbpilper.Text == "Persibat vs Persip 31-11-2025")
            {
                Form4 Form4 = new Form4();
                Form4.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
