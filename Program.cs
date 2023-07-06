using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Increment_and_Decrease_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arttırma operatörü : ++
            // Azaltma operatörü  : --

            int sayi = 20;

            sayi++; //burada bir arttırdık.
            sayi--; //burada bir azalttık.

            Console.WriteLine(sayi);
            Console.ReadLine();
        }
    }
}
