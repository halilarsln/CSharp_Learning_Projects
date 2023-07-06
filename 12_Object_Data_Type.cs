using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Object_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veri tiplerinin atasıdır.
            //bütün veri tiplerini tutabilir.


            object a = "halil";
            object b = 155;
            object c = '5';
            object d = 3.14;
            object e = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}
