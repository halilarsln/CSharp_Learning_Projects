using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Or_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {// Veya Operatorü : Alt Gr + z tusunun sol tarafındaki tuş büyüktür küçüktür sembolü olan

            int sayi1 = 3;

            int sayi2 = 3;

            int sayi3 = 6;
            
            bool kontrolet = sayi1==sayi2|| sayi2>sayi3;
            //en az bir tane true degeri varsa true olur.

            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
