﻿using System;
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
            Karyawan ky0 = new Karyawan();
            ky0.Nik = "123456";
            ky0.Nama = "Paijo";
            ky0.GajiBulanan = 3000000;

            Karyawan ky1 = new Karyawan();
            ky1.Nik = "123456";
            ky1.Nama = "Budi";
            ky1.GajiBulanan = -1000;

            if (ky0.GajiBulanan < 0)
                ky0.GajiBulanan = 0;
            if (ky1.GajiBulanan < 0)
                ky1.GajiBulanan = 0;

            Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1. {0} {1}\t {2}", ky0.Nik, ky0.Nama, ky0.GajiBulanan);
            Console.WriteLine("1. {0} {1}\t {2}", ky1.Nik, ky1.Nama, ky1.GajiBulanan);

            Console.WriteLine("");
            Console.WriteLine("\nAsyiiiiikkk kenaikan gaji 10%!!");
            Console.WriteLine("");

            Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1. {0} {1}\t {2}", ky0.Nik, ky0.Nama, ky0.GajiBulanan + ky0.GajiBulanan * 0.10);
            Console.WriteLine("1. {0} {1}\t {2}", ky1.Nik, ky1.Nama, ky1.GajiBulanan + ky1.GajiBulanan * 0.10);
            Console.ReadKey();
        }
    }
}
