using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Addition_and_Subtraction_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama operatörü : +
            // Çıkarma operatörü : +

            int sayi1 = 5;
            int sayi2 = 12;
            int sayi3 = 55; //sonradan ekleme yapabiliriz

            int sonuc1 = sayi1 + sayi2 + sayi3;  //toplama
            int sonuc2 =( sayi1 +sayi2 )- sayi1;  //çıkarma
            //önce parantezde işlem yapılır.

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.ReadLine();







        }
    }
}
