using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Equal_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eşittir Operatörü : ==

            int sayi1 = 4;
            int sayi2 = 4;
            int sayi3 = 8;

            //true ya da false çıkacak

            bool kontrolEt =sayi1 == sayi2; //true çıkacak
            
            bool bak=sayi1 == sayi3; //false çıkacak

            Console.WriteLine(kontrolEt);
            Console.WriteLine(bak);
            Console.ReadLine();
        }
    }
}
