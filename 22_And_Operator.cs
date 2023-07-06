using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_And_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve Operatörü shift+6

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool KontrolEt = sayi1 == sayi2 && sayi1 < sayi3;
            
            Console.WriteLine(KontrolEt);
            Console.ReadLine();
        }
    }
}
