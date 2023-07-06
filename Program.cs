using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Multiplication_and_Division_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çarpma operatörü : *
            // Bölme  operatörü : /

            int sayi1 = 7;
            int sayi2 = 14;

            int sonuc=sayi1*sayi2;
            int sonuc1 = sayi2 / sayi1;


            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc1);
            Console.ReadLine();
        }
    }
}
