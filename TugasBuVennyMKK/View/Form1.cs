using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBuVennyMKK.Controller;
using TugasBuVennyMKK.Model;

namespace TugasBuVennyMKK
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        Pelajar_m pelajar = new Pelajar_m();
        string id;

        public void Tampil()
        {
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM pelajar");

            DataTable.Columns[0].HeaderText = "#";
            DataTable.Columns[1].HeaderText = "NISN";
            DataTable.Columns[2].HeaderText = "Nama Pelajar";
            DataTable.Columns[3].HeaderText = "Kelas";
            DataTable.Columns[4].HeaderText = "Alamat";
            DataTable.Columns[5].HeaderText = "Email";
            DataTable.Columns[6].HeaderText = "No Handphone";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NISN.Text == "" || NamaPelajar.Text == "" || Kelas.SelectedIndex == -1 || Alamat.Text == "" || Email.Text == "" || NoHp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelajar_c pl = new Pelajar_c();
                pelajar.Nisn = NISN.Text;
                pelajar.Nama = NamaPelajar.Text;
                pelajar.Kelas = Kelas.Text;
                pelajar.Alamat = Alamat.Text;
                pelajar.Email = Email.Text;
                pelajar.Nohp = NoHp.Text;

                pl.Insert(pelajar);
                NISN.Text = "";
                NamaPelajar.Text = "";
                Kelas.SelectedIndex = -1;
                Alamat.Text = "";
                Email.Text = "";
                NoHp.Text = "";

                Tampil();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cari_Click(object sender, EventArgs e)
        {

        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            NISN.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            NamaPelajar.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            Kelas.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            Alamat.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            Email.Text = DataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            NoHp.Text = DataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (NISN.Text == "" || NamaPelajar.Text == "" || Kelas.SelectedIndex == -1 || Alamat.Text == "" || Email.Text == "" || NoHp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelajar_c pl = new Pelajar_c();
                pelajar.Nisn = NISN.Text;
                pelajar.Nama = NamaPelajar.Text;
                pelajar.Kelas = Kelas.Text;
                pelajar.Alamat = Alamat.Text;
                pelajar.Email = Email.Text;
                pelajar.Nohp = NoHp.Text;

                pl.Update(pelajar,id);
                NISN.Text = "";
                NamaPelajar.Text = "";
                Kelas.SelectedIndex = -1;
                Alamat.Text = "";
                Email.Text = "";
                NoHp.Text = "";

                Tampil();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(pesan == DialogResult.Yes )
            {
                Pelajar_c pl = new Pelajar_c();
                pl.Delete(id);
                Tampil();
            }
        }

        private void CariData_TextChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM pelajar WHERE nisn LIKE '%' '" + CariData.Text + "' '%' OR nama LIKE '%' '" + CariData.Text + "' '%'");

        }
    }
}
