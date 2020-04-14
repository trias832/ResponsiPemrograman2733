using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2733
{
   public class Karyawan
    {
        //Constructor
        public Karyawan(int nik,string nama,int gajiBulanan)
        {
            Nik = nik;
            Nama = nama;
            if(gajiBulanan < 0)
            {
                GajiBulanan = 0;
                Naik = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                GajiBulanan = gajiBulanan;
                Naik = Convert.ToInt32((GajiBulanan * 1.1));
            }

        }


        //properties
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Naik { get; set; }
        

    }
}
