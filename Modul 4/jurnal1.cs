using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul_4_Csharp
{
    struct Databeli
    {
        public string nama, alamat, tgl;
        public int jmlh;
        public float luas, p, l;
    }

    internal class jurnal1
    {
        static void Main(string[] args)
        {
            Databeli[] semuaBeli;
            Console.WriteLine("= = = = = PROGRAM DATA SULIT = = = = =");
            Console.WriteLine("Jumlah pembeli: ");
            int jumlahPembeli = Convert.ToInt32(Console.ReadLine());

            semuaBeli = new Databeli[jumlahPembeli];

            for (int i = 0; i < jumlahPembeli; i++)
            {
                Console.WriteLine("Data ke-" + (i + 1));
                Console.WriteLine("Nama Pembeli: ");
                semuaBeli[i].nama = Console.ReadLine();

                Console.WriteLine("Alamat: ");
                semuaBeli[i].alamat = Console.ReadLine();

                Console.WriteLine("Tanggal: ");
                semuaBeli[i].tgl = Console.ReadLine();

                Console.WriteLine("Panjang tanah: ");
                semuaBeli[i].p = float.Parse(Console.ReadLine());

                Console.WriteLine("Lebar tanah: ");
                semuaBeli[i].l = float.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                semuaBeli[i].luas = semuaBeli[i].p * semuaBeli[i].l;
            }

            Console.WriteLine("= = = = = TOTAL DATA PEMBELI = = = = =");
            for (int i = 0; i < jumlahPembeli; i++)
            {
                Console.WriteLine("Data ke-" + (i + 1));
                Console.WriteLine("Nama Pembeli: " + semuaBeli[i].nama);
                Console.WriteLine("Alamat: " + semuaBeli[i].alamat);
                Console.WriteLine("Tanggal: " + semuaBeli[i].tgl);
                Console.WriteLine("Luas tanah: " + semuaBeli[i].luas);
                Console.WriteLine("\n");
            }
        }
    }
}
