using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2628
{
    class Karyawan
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public Karyawan(string nim, string nama, int gajibulanan)
        {
            Nim = nim;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }

        public void DataKaryawan()
        {
            Console.WriteLine(" {0} {1}    {2}", Nim, Nama, GajiBulanan);
        }
        public void NaikGaji()
        {
            Console.WriteLine(" {0} {1}    {2}", Nim, Nama, (GajiBulanan * 110 / 100));
        }
    }
}