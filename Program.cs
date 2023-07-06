using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Readline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Readline

            Console.WriteLine("Lütfen Adınızı Giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyismizi giriniz");

            string soyisim = Console.ReadLine();

            Console.WriteLine("kullanıcın ismi:"+isim);
            Console.WriteLine("kullanıcınım soyismi:" + soyisim);
            Console.ReadLine();
        }
    }
}
