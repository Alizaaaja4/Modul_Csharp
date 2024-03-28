using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_1_c_
{
    internal class mandiri2
    {
        static void Main(string[] args)
        {
            const float phi = 3.14f;
            float r, s, LP;

            Console.WriteLine("Masukan jari-jari: ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("Masukan selimut: ");
            s = float.Parse(Console.ReadLine());

            LP = phi * r*(r+s);

            Console.WriteLine("Luas permukaan: " + LP + "cm^3");
        }
    }
}
