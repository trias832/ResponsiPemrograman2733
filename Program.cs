using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2733
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("No       NIK             NAMA                GAJI BULANAN                ");
            Console.WriteLine("=========================================================================");
            //membuat objek Karyawan 1
            Karyawan kry1 = new Karyawan(1903423243,"trias", 3000000);
            Console.WriteLine("1.       {0}             {1}                 {2}                         ",kry1.Nik,kry1.Nama,kry1.GajiBulanan);
            //membuat objek karyawan2
            Karyawan kry2 = new Karyawan(1902348623, "handayani", 200000);
            Console.WriteLine("2.       {0}             {1}             {2}                         ", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\nAsyik kenaikan gaji 10%");
            Console.WriteLine("No       NIK             NAMA                GAJI BULANAN                ");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1.       {0}             {1}                 {2}                         ", kry1.Nik, kry1.Nama,kry1.Naik);
            Console.WriteLine("2.       {0}             {1}             {2}                         ", kry2.Nik, kry2.Nama, kry2.Naik);


            Console.ReadKey();
        }
      
    }
}
