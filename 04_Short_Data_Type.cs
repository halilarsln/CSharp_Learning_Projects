using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Short_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir.
            
            short birinciDegisken = -50;

            short ikinciDegisken = 25500;

            short ucuncuDegisken = 32000;

            short MaxDeger = short.MaxValue;

            short MinDeger = short.MinValue;

            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);
            Console.ReadLine(); 
            



        }
    }
}
