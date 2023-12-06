using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBuVennyMKK.Model
{
    internal class Pelajar_m
    {
        string nisn, nama, kelas, alamat, email, nohp;

        public Pelajar_m() { }

        public Pelajar_m(string nisn, string nama, string kelas, string alamat, string email, string nohp)
        {
            this.Nisn = nisn;
            this.Nama = nama;
            this.Kelas = kelas;
            this.Alamat = alamat;
            this.Email = email;
            this.Nohp = nohp;
        }

        public string Nisn { get => nisn; set => nisn = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
