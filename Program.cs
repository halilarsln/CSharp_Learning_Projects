using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Array_Identification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string
            //double
            //char

            //string[] isimler = new string[4]; 4 tane eleman tutabilen dizidir.

            string[] isimler = { "Halil", "Şevval", "Gülgün", "Ayşe", "Mehmet" };

            Console.Write(isimler[1]+isimler[0]+"birtakım");

            Console.ReadLine();

            for (int i = 0; i < isimler.Length; i++) //uzunlugu kadar birer birer arttır
            {
                Console.WriteLine(isimler[i]); //döngü bittiginde ekrana yazdıracak
            }
            Console.ReadLine();
        }
    }
}
