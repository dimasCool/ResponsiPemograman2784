using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemograman2784
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan user1 = new Karyawan(19112784, 7500000, "Dhimas");
            Karyawan user2 = new Karyawan(10101010, 4000000, "Wicaksana");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", user1.Nik, user1.Nama, user1.GajiBulanan);
            Console.WriteLine("2. \t {0} {1} \t\t {2}", user2.Nik, user2.Nama, user2.GajiBulanan);

            Console.WriteLine("");

            Console.WriteLine("Asyiiik kenaikan gaji 10%");

            Console.WriteLine("");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", user1.Nik, user1.Nama, user1.NaikGaji);
            Console.WriteLine("2. \t {0} {1} \t\t {2}", user2.Nik, user2.Nama, user2.NaikGaji);
        }
    }

    class Karyawan
    {

        public int Nik { get; set; }
        public int GajiBulanan { get; set; }
        public string Nama { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int Nik, int inputgaji, string Nama)
        {

            this.Nik = Nik;
            this.Nama = Nama;

            if (inputgaji < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = inputgaji;
            }

            double rumus = 0;
            rumus = 0.1 * GajiBulanan;
            NaikGaji = Convert.ToInt32(rumus) + GajiBulanan;

        }
    }
}
