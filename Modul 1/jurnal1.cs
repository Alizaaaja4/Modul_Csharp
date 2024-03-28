using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_1_c_
{
    internal class jurnal1
    {
        static void Main(string[] args)
        {
            float panjangasli = 150, lebarasli = 100, hargaasli = 800000;
            float panjangbeli, lebarbeli, luasbeli, hargatotal;
            float sisaP, sisaL;
            Console.WriteLine("================ PROGRAM MENGHITUNG SISA TANAH ==============");
            Console.WriteLine("Masukan panjang: "); panjangbeli = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukan lebar: "); lebarbeli = float.Parse(Console.ReadLine());

            luasbeli = panjangbeli * lebarbeli;
            hargatotal = hargaasli * luasbeli;
            sisaP = panjangasli - panjangbeli;
            sisaL = lebarasli - lebarbeli;

            Console.WriteLine("Luas tanag yang dibeli: " + luasbeli + "m^2");
            Console.WriteLine("Harga tanah: Rp " + hargatotal);
            Console.WriteLine("Sisa panjang tanah: " + sisaP + "m");
            Console.WriteLine("Sisa lebar tanah: " +  sisaL + "m");

        }
    }
}
