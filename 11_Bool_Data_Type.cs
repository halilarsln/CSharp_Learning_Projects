using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Bool_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 tane ihtimalin(alternatif) olduğu yerlerde kullanılan veri tipidir.
            // Halil bugün okula gitti mi? bu sorunun 2 cevabı vardır. evet ya da hayır

            bool kontrol = true; //dogru

            bool kontrol2 = false; //yanlış

            bool Sonuc = 10 > 5;
            bool Sonuc2 = 8 < 5;

            Console.WriteLine(Sonuc);
            Console.WriteLine(Sonuc2);

            Console.ReadLine(); 



        }
    }
}
