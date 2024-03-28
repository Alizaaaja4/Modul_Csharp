using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_1_c_
{
    internal class mandiri1
    {
        static void Main(string[] args)
        {
            string nama; float aka, kp, index;

            Console.WriteLine("Nama: "); nama = Console.ReadLine();
            Console.WriteLine("Kepemimpinan: "); kp = float.Parse(Console.ReadLine());
            Console.WriteLine("Akademik: "); aka = float.Parse(Console.ReadLine());

            index = (0.6f * kp + 0.4f * aka);

            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("kepemimpinan: " + kp);
            Console.WriteLine("Akademik: " + aka);
            Console.WriteLine("Index Nilai: " + index);        }
    }
}
