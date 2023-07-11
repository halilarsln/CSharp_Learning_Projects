using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10'a kadar olan sayıları ekrana yazdırın.(do while ile);

            //1'den 100'e kadar olan sayıların toplamını ekrana yazdırınız(do while ile);

            /*int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;

            } while (a<=10);

            Console.ReadLine();*/

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a <= 100);

            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı:"+toplam);

            Console.ReadLine();



        }
    }
}
