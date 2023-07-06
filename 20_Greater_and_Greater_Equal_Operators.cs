using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Greater_and_Greater_Equal_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Büyüktür operatörü : >
            //Büyük ve Eşittir operatörü: >=

            int yaş = 17;

            bool KontrolEt = yaş >= 17;
            bool bak = yaş > 18;

            Console.WriteLine(KontrolEt);
            Console.WriteLine(bak);
            Console.ReadLine();

        }
    }
}
