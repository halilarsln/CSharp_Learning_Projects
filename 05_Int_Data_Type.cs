using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Int_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İnt veri Tipi -2.147,483.648 ile 2.147.483.647 arasında değer depolayabilmektedir.
            //4 byte yer kaplar.

            //8 bit = 1 byte
            //1024 byte = 1KB(kilobyte)
            //1024 KB = 1MB(megabyte)
            //1024MB = 1GB(gigabyte)
            //1024GB= 1TB(terabyte)
            //1024TB=1 PB(petabyte)

            int birinciDegisken = 150000;

            int ikinciDegisken = -500000;

            int MaxDeger=int.MaxValue;

            int MinDeger=int.MinValue; 

            //Console.WriteLine(birinciDegisken);
            //Console.WriteLine(ikinciDegisken);
            
            Console.WriteLine(MinDeger);

            Console.WriteLine(MaxDeger);

            Console.ReadLine();

        }
    }
}
