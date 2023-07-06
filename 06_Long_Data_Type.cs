using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Long_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 arasında değer depolayabilmektedir.
            //8 byte yer kaplar rambellekte

            long birinciDegisken = 57500;

            long ikinciDegisken = -500;

            long MaxDeger=long.MaxValue;

            long MinDeger=long.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);

            Console.ReadLine();


        }
    }
}
