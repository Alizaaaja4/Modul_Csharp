using System;

namespace modul_3_Csharp
{
    internal class jurnal1
    {
        static void Main(string[] args)
        {
            string jawab;
            bool jawabanBenar = false;

            Console.WriteLine("= = = = = PROGRAM MINI QUIZ = = = = =");

            for (int i = 0; i < 3 && !jawabanBenar; i++)
            {
                Console.WriteLine("PT apa yg sulit masuk: ");
                jawab = Console.ReadLine();

                if (jawab.Equals("telkomsel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Selamat!! Jawaban anda benar");
                    jawabanBenar = true;
                }
                else if (i < 2)
                {
                    Console.WriteLine("Jawaban anda masih salah!!");
                }
                else
                {
                    Console.WriteLine("Maaf kesempatan anda telah habis");
                }
            }
        }
    }
}
