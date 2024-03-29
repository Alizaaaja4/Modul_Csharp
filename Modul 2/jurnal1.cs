using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_2_Csharp
{
    internal class jurnal1
    {
        static void Main(string[] args)
        {
            string p1, p2, pass;
            Console.WriteLine("======= PROGRAM LOGIN SEDERHANA =======\n");
            Console.WriteLine("Bot: Siapa nama sahabat pertama saya ? ");
            p1 = Console.ReadLine();
            Console.WriteLine("Bot: Siapa nama lab terkece ? ");
            p2 = Console.ReadLine();

            if (p1 == "Daskom" && p2 == "DaskomLab")
            {
                Console.WriteLine("== Jawaban anda benar !! ==\n\n");

                Console.WriteLine("Input kata sandi baru: ");
                pass = Console.ReadLine();

                Console.WriteLine("Kata sandi baru ( " + pass + " ) telah dibuat!!");
            }
            else
            {
                Console.WriteLine("\n== Jawaban anda salah !! ==");
                Console.WriteLine("== Silahkan coba kembali ==");
            }
        }
    }
}
