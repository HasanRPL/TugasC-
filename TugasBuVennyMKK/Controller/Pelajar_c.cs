using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBuVennyMKK.Model;

namespace TugasBuVennyMKK.Controller
{
    internal class Pelajar_c
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(Pelajar_m pelajar)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO pelajar (nisn, nama, kelas, alamat, email, nohp) VALUES ('" + pelajar.Nisn + "', '" + pelajar.Nama + "', '" + pelajar.Kelas + "', '" + pelajar.Alamat + "', '" + pelajar.Email + "', '" + pelajar.Nohp + "' )");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Update(Pelajar_m pelajar, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE pelajar SET nisn='" + pelajar.Nisn + "', " + "nama='" + pelajar.Nama + "', " + "kelas='" + pelajar.Kelas + "', " + "alamat='" + pelajar.Alamat + "',  " + "email='" + pelajar.Email + "', " + "nohp='" + pelajar.Nohp + "' WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM pelajar WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
