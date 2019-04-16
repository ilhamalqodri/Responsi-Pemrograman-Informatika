using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2340
{
    class Karyawan
    {
        private string nik;
        private string nama;
        private int gaji;
        private int bonus;

        public string Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gaji; }
            set { gaji = value; }
        }
    }
}
