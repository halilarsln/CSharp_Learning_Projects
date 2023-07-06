using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Less_than_and_Less_than_Equal_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Küçüktür Operatörü : <
            // Küçük Eşit Operatorü: <=

            int yas = 25;

            bool Sonuc = yas < 26;
            bool bak = yas <= 25;

            Console.WriteLine(Sonuc);
            Console.WriteLine(bak);
            Console.ReadLine();

        }
    }
}
