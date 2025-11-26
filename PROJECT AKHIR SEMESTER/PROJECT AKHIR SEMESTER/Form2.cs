using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_AKHIR_SEMESTER
{
    public partial class FormP1 : Form
    {
        int tribun1 = 850;
        int tribun2 = 850;
        int tribunvip = 700;
        public FormP1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Tribun Timur");
            comboBox2.Items.Add("Tribun Selatan");
            comboBox2.Items.Add("Tribun VIP");


            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Tribun Timur", "Rp. 25.000", tribun1);
            dataGridView1.Rows.Add("Tribun Selatan", "Rp. 25.000", tribun2);
            dataGridView1.Rows.Add("Tribun VIP", "Rp. 50.000", tribunvip);


        }

        private void buttontampil_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Tribun Selatan")
            {
                string harga = $"{Convert.ToInt32(textBox1.Text) * 25000}";
                dataGridView2.Rows.Add(label7.Text, "Tribun Selatan", textBox1.Text, harga);
            }
            else if (comboBox2.Text == "Tribun Timur")
            {
                string harga = $"{Convert.ToInt32(textBox1.Text) * 25000}";
                dataGridView2.Rows.Add(label7.Text, "Tribun Timur", textBox1.Text, harga);
            }
            else if (comboBox2.Text == "Tribun VIP")
            {
                string harga = $"{Convert.ToInt32(textBox1.Text) * 50000}";
                dataGridView2.Rows.Add(label7.Text, "Tribun VIP", textBox1.Text, harga);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stokktimbaru = 0;
            int stokselbaru = 0;
            int stokvipbaru = 0;
            int harga = 0;
            


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text))

            {
                MessageBox.Show("Silahkan Lengkapi Pemesanan Terlebih Dahulu", "peringatan", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxbayar.Text))
            {
                MessageBox.Show("Silahkan Bayar Pesanan Anda", "peringatan", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                return;
            }
            int uangbayar = Convert.ToInt32(textBoxbayar.Text);

            if (comboBox2.Text == "Tribun Timur")
            {
                harga = Convert.ToInt32(textBox1.Text) * 25000;

                tribun1 = tribun1 - Convert.ToInt32(textBox1.Text);
                stokktimbaru = tribun1;
                if (stokktimbaru >= 0 && uangbayar >= harga)
                    if (dataGridView1.Rows.Count > 0)
                    {
                        // Jika AllowUserToAddRows = true, pastikan tidak hanya ada baris kosong
                        if (!(dataGridView1.Rows.Count == 1 && dataGridView1.AllowUserToAddRows))
                        {
                            dataGridView1.Rows.RemoveAt(0); // Hapus baris pertama
                            dataGridView1.Rows.Insert(0, "Tribun Timur", "Rp. 25.000", stokktimbaru);
                        }
                    }


            }
            if (comboBox2.Text == "Tribun Selatan")
            {
                harga = Convert.ToInt32(textBox1.Text) * 25000;

                tribun2 = tribun2 - Convert.ToInt32(textBox1.Text);
                stokselbaru = tribun2;
                if (stokselbaru >= 0 && uangbayar >= harga)
                if (dataGridView1.Rows.Count > 0)
                {
                    // Jika AllowUserToAddRows = true, pastikan tidak hanya ada baris kosong
                    if (!(dataGridView1.Rows.Count == 2 && dataGridView1.AllowUserToAddRows))
                    {
                        dataGridView1.Rows.RemoveAt(1); // Hapus baris kedua
                            dataGridView1.Rows.Insert(1, "Tribun Selatan", "Rp. 25.000", stokselbaru);
                        }
                }
                
                


            }
            if (comboBox2.Text == "Tribun VIP")
            {
                harga = Convert.ToInt32(textBox1.Text) * 50000;
                tribunvip = tribunvip - Convert.ToInt32(textBox1.Text);
                stokvipbaru = tribunvip;
                if(stokvipbaru >= 0 && uangbayar >= harga)
                if (dataGridView1.Rows.Count > 0)
                {
                    // Jika AllowUserToAddRows = true, pastikan tidak hanya ada baris kosong
                    if (!(dataGridView1.Rows.Count == 3 && dataGridView1.AllowUserToAddRows))
                    {
                        dataGridView1.Rows.RemoveAt(2); // Hapus baris ketiga
                            dataGridView1.Rows.Insert(2, "Tribun VIP", "Rp. 50.000", stokvipbaru);
                        }
                }
              

            }
            else if (textBox1 == null)
            {
                MessageBox.Show("Harap isi jumlah beli sesuai stok tiket!");
            }
            
           

            if (!int.TryParse(textBoxbayar.Text, out uangbayar))
            {
                MessageBox.Show("Masukkan angka yang bener ya cukimay");
                return;
            }

            if (uangbayar < harga)
            {
                MessageBox.Show("Uang Tidak Cukup");
            }
            else if (uangbayar == harga)
            {
                MessageBox.Show("Pembayaran Berhasil! Terima kasih.");
            }
            else
            {
                int kembalian = uangbayar - harga;
                MessageBox.Show("Pembayaran Berhasil! \nKembalian Anda : Rp" + kembalian);
            }
        }

        private void textBoxbayar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxbayar.Text))
            {
                if (int.TryParse(textBoxbayar.Text, out int textboxbayar))
                {
                    return;
                }
                else
                {
                    textBoxbayar.Clear();
                    MessageBox.Show("Isi Pakai Angka Yaaa, DASAR KANEBO KERING");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void buttonhapusrows_Click(object sender, EventArgs e)
        {



            if (dataGridView2.Rows.Count > 0)
            {
                // Jika AllowUserToAddRows aktif, baris kosong di akhir harus diabaikan
                int lastRowIndex = dataGridView2.AllowUserToAddRows
                    ? dataGridView2.Rows.Count - 2   // Lewati baris kosong terakhir
                    : dataGridView2.Rows.Count - 1;

                if (lastRowIndex >= 0)
                {
                    dataGridView2.Rows.RemoveAt(lastRowIndex);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada detail pesanan yang dapat dihapus!",
                                "Peringatan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show(
           "Apakah Anda yakin ingin menutup program?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tutup semua form dan hentikan aplikasi
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int textbox1))
                {
                    if (comboBox2.Text == "Tribun Timur")
                    {
                        if (textbox1 > tribun1)
                        {
                            textBox1.Clear();
                            MessageBox.Show("Pesanan melebihi Jumlah Stok!", "peringatan", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                        }
                    }

                    else if (comboBox2.Text == "Tribun Selatan")
                    {
                        if (textbox1 > tribun2)
                        {
                            textBox1.Clear();
                            MessageBox.Show("Pesanan melebihi Jumlah Stok!", "peringatan", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                        }
                    }

                    else if (comboBox2.Text == "Tribun VIP")
                    {
                        if (textbox1 > tribunvip)
                        {
                            textBox1.Clear();
                            MessageBox.Show("Pesanan melebihi Jumlah Stok!", "peringatan", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    textBox1.Clear();
                    MessageBox.Show("Isi Menggunakan Angka Yaa!");
                }
            }
        }
    }
}
