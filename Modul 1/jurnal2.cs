using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_1_c_
{
    internal class jurnal2
    {
        static void Main(string[] args)
        {
            string nama, telp;
            float pixharga = 1000000;
            float p, l, luas, harga;

            Console.WriteLine("Nama: ");
            nama = Console.ReadLine();

            Console.WriteLine("Nomor telp: ");
            telp = Console.ReadLine();

            Console.WriteLine("Panjang: ");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("Lebar: ");
            l = float.Parse(Console.ReadLine());

            harga = (p * l) * pixharga;
            luas = p * l;

            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Nomor telp: " + telp);
            Console.WriteLine("Luas tanah: " + luas + " m^2");
            Console.WriteLine("Harga: Rp " + harga);
        }
    }
}
