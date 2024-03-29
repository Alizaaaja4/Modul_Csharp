using System;

namespace modul_3_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama, kelas, jurusan, nim; int jumlah;

            Console.WriteLine("= = = = = PROGRAM INPUT DATA = = = = =");
            Console.WriteLine("Input jumlah data: ");
            jumlah = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= jumlah; i++)
            {
                Console.WriteLine("Data ke-" +i);
                Console.WriteLine("Nama: ");
                nama = Console.ReadLine();
                Console.WriteLine("Kelas: ");
                kelas = Console.ReadLine();
                Console.WriteLine("Jurusan: ");
                jurusan = Console.ReadLine();
                Console.WriteLine("NIM: ");
                nim = Console.ReadLine();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Data berhasil dimasukkan!!");
        }
    }
}
