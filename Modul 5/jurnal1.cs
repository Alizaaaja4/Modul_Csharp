using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_5_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("= = = = = = = PROGRAM KALKULATOR MEDIUM = = = = = = =");
            Console.WriteLine("= = = [1]. Penjumlahan         [2]. Pengurangan = = =");
            Console.WriteLine("= = = [3]. Perkalian           [4]. Pembagian   = = =");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = =");
            Console.WriteLine("Input /> ");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1: penjumlahan();  break;
                case 2: pengurangan(); break;
                case 3: perkalian(); break;
                case 4: pembagian(); break;
                default: Console.WriteLine("Maaf option tidak ada\n\n"); 
                    Main(args); break;
            }

        }

        static void penjumlahan()
        {
            float a, b, c;
            Console.WriteLine("= = = = = = PENJUMLAHAN = = = = = =");
            Console.WriteLine("Angka ke-1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Angka ke-2: ");
            b = float.Parse(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Hasil " + a +" + " + b + " = " + c);
        }

        static void pengurangan()
        {
            float a, b, c;
            Console.WriteLine("= = = = = = PENGURANGAN = = = = = =");
            Console.WriteLine("Angka ke-1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Angka ke-2: ");
            b = float.Parse(Console.ReadLine());

            c = a - b;
            Console.WriteLine("Hasil " + a + " - " + b + " = " + c);
        }

        static void perkalian()
        {
            float a, b, c;
            Console.WriteLine("= = = = = = PERKALIAN = = = = = =");
            Console.WriteLine("Angka ke-1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Angka ke-2: ");
            b = float.Parse(Console.ReadLine());

            c = a * b;
            Console.WriteLine("Hasil " + a + " x " + b + " = " + c);
        }
        
        static void pembagian()
        {
            float a, b, c;
            Console.WriteLine("= = = = = = PEMBAGIAN = = = = = =");
            Console.WriteLine("Angka ke-1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Angka ke-2: ");
            b = float.Parse(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Hasil " + a + " / " + b + " = " + c);
        }
    }
}
