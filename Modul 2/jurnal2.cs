using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_2_Csharp
{
    internal class jurnal2
    {
        static void Main(string[] args)
        {
            float m, h, v, total; const float g = 10; int pilih;
            Console.WriteLine("===== PROGRAM KALKULATOR ENERGI =====");
            Console.WriteLine("[1]. Energi Potensial");
            Console.WriteLine("[2]. Energi Kinetik");
            Console.WriteLine("Input: ");
            pilih = Convert.ToInt16(Console.ReadLine());

            switch (pilih)
            {
                case 1: Console.WriteLine("Massa (kg): ");
                    m = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ketinggian (m): ");
                    h = float.Parse(Console.ReadLine());

                    total = m * g * h;

                    Console.WriteLine("Energi potensial: " + total + " J");
                    break;

                case 2: Console.WriteLine("Massa (kg): ");
                    m = float.Parse(Console.ReadLine());
                    Console.WriteLine("Kecepatan: ");
                    v = float.Parse(Console.ReadLine());

                    total = (float)(0.5 * m * Math.Pow(v, 2));

                    Console.WriteLine("Energi Kinetik: " + total + " J");
                    break;

                default:
                Console.WriteLine("Pilihan tidak tersedia.");
                break;
            }
        }
    }
}
