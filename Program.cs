using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach döngüsü
            
            /*string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };
              
            /* for (int i = 0; i<isimler.Length; i++)
            {
            Console.WriteLine(isimler[i]);
            }*/

            /* foreach (string a in isimler)
            {
            Console.WriteLine(a);
            }*/

            double[] os = { 1.2, 1.4, 1.8, 2.2 };
            foreach (double d in os)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
