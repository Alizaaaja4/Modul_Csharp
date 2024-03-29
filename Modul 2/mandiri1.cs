using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_2_Csharp
{
    internal class mandiri1.cs
    {
        static void Main(string[] args)
        {
            string nama1, nama2, nama3;
            float r1, r2, r3, t1, t2, t3; const float phi = 3.14f;

            Console.WriteLine("= = = = =  Kastil 1 = = = = =");
            Console.WriteLine("= Nama : ");
            nama1 = Console.ReadLine();
            Console.WriteLine("Radius tembok: ");
            r1 = float.Parse(Console.ReadLine());

            Console.WriteLine("= = = = = Kastil 2 = = = = =");
            Console.WriteLine("= Nama : ");
            nama2 = Console.ReadLine();
            Console.WriteLine("Radius tembok: ");
            r2 = float.Parse(Console.ReadLine());

            Console.WriteLine("= = = = = Kastik 3 = = = = =");
            Console.WriteLine("= Nama : ");
            nama3 = Console.ReadLine();
            Console.WriteLine("Radius tembok: ");
            r3 = float.Parse(Console.ReadLine());

            // operasi
            t1 = 2*phi*r1;
            t2 = 2*phi*r2;
            t3 = 2*phi*r3;

            if ( t1 < t2 && t2 < t3)
            {
                Console.WriteLine("= = = = = kastil 1 = = = = =");
                Console.WriteLine("= Nama: " + nama1);
                Console.WriteLine("= Radius tembok: " + r1);
                Console.WriteLine("= Keliling: " + t1);
                Console.WriteLine("= = = = = kastil 2 = = = = =");
                Console.WriteLine("= Nama: " + nama2);
                Console.WriteLine("= Radius tembok: " + r2);
                Console.WriteLine("= Keliling: " + t2);
                Console.WriteLine("= = = = = kastil 3 = = = = =");
                Console.WriteLine("= Nama: " + nama3);
                Console.WriteLine("= Radius tembok: " + r3);
                Console.WriteLine("= Keliling: " + t3);
                Console.WriteLine("\n kastil 1 merupakan kastil dengan tembok terpendek");
            } else if ( t1 > t2 && t2 < t3)
            {
                Console.WriteLine("= = = = = kastil 1 = = = = =");
                Console.WriteLine("= Nama: " + nama1);
                Console.WriteLine("= Radius tembok: " + r1);
                Console.WriteLine("= Keliling: " + t1);
                Console.WriteLine("= = = = = kastil 2 = = = = =");
                Console.WriteLine("= Nama: " + nama2);
                Console.WriteLine("= Radius tembok: " + r2);
                Console.WriteLine("= Keliling: " + t2);
                Console.WriteLine("= = = = = kastil 3 = = = = =");
                Console.WriteLine("= Nama: " + nama3);
                Console.WriteLine("= Radius tembok: " + r3);
                Console.WriteLine("= Keliling: " + t3);
                Console.WriteLine("\n kastil 2 merupakan kastil dengan tembok terpendek");
            }
            else
            {
                Console.WriteLine("= = = = = kastil 1 = = = = =");
                Console.WriteLine("= Nama: " + nama1);
                Console.WriteLine("= Radius tembok: " + r1);
                Console.WriteLine("= Keliling: " + t1);
                Console.WriteLine("= = = = = kastil 2 = = = = =");
                Console.WriteLine("= Nama: " + nama2);
                Console.WriteLine("= Radius tembok: " + r2);
                Console.WriteLine("= Keliling: " + t2);
                Console.WriteLine("= = = = = kastil 3 = = = = =");
                Console.WriteLine("= Nama: " + nama3);
                Console.WriteLine("= Radius tembok: " + r3);
                Console.WriteLine("= Keliling: " + t3);
                Console.WriteLine("\n kastil 3 merupakan kastil dengan tembok terpendek");
            }
        }
    }
}
