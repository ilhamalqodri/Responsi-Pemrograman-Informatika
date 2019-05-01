using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi Pemrog tahun 2018/2019;
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan ObjKaryawan = new Karyawan();
            ObjKaryawan.Nik = "123456";
            ObjKaryawan.Nama = "Paijo";
            ObjKaryawan.GajiBulanan = 3000000;

            Karyawan ObjKaryawan2 = new Karyawan();
            ObjKaryawan2.Nik = "123456";
            ObjKaryawan2.Nama = "Budi";
            ObjKaryawan2.GajiBulanan = -1000;

            if (ObjKaryawan.GajiBulanan < 0)
                ObjKaryawan.GajiBulanan = 0;
            if (ObjKaryawan2.GajiBulanan < 0)
                ObjKaryawan2.GajiBulanan = 0;

            Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1. {0} {1}\t {2}", ObjKaryawan.Nik, ObjKaryawan.Nama, ObjKaryawan.GajiBulanan);
            Console.WriteLine("1. {0} {1}\t {2}", ObjKaryawan2.Nik, ObjKaryawan2.Nama, ObjKaryawan2.GajiBulanan);

            Console.WriteLine("");
            Console.WriteLine("\nAsyiiiiikkk kenaikan gaji 10%!!");
            Console.WriteLine("");

            Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1. {0} {1}\t {2}", ObjKaryawan.Nik, ObjKaryawan.Nama, ObjKaryawan.GajiBulanan + ObjKaryawan.GajiBulanan * 0.10);
            Console.WriteLine("1. {0} {1}\t {2}", ObjKaryawan2.Nik, ObjKaryawan2.Nama, ObjKaryawan2.GajiBulanan + ObjKaryawan2.GajiBulanan * 0.10);
            Console.ReadKey();
        }
    }
}
