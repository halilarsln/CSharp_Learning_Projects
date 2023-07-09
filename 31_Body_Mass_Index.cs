﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Body_Mass_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beden Kitle İndeksi = Kilo / (boy*boy)
            //Beden Kitle İndeksi 18'e eşit veya düşükse zayıf
            // 18 ile 25 arasında Normal
            // 25'ten büyükse OBEZ yazdıran program parçasını kodlayınız.

            Console.WriteLine("Kilonuzu Giriniz");
            int kilo =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Girişiniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke<18) 
            { 
                Console.WriteLine("Zayıfsınız..."); 
                Console.ReadLine();
            }
            else if (bke>18 && bke<25)
            { 
                Console.WriteLine("Normalsiniz");
                Console.ReadLine();
            }
            else if (bke>25)
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();
            }
        }
    }
}
