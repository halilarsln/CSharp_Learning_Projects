using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Multiplication_Table_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu projemizde çarpım tablosu yapacağız for döngüsü ile

            for(int i=1; i<=10; i++)
            {
                for(int j=1;j<=10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
            }
            Console.ReadLine();

        }
    }
}
