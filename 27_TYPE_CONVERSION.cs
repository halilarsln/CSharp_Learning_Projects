using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_TYPE_CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int veri tipini byte veri tipine dönüştürme

            /*int a = 5;

            byte b=(byte)a; 

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console .ReadLine(); */

            //string veri tipini int vri tipine dönüştürme
            //1.yöntem

            /*string sayi1 = "1";
            string sayi2 = "2";

            int a= int.Parse(sayi1);
            int b= int.Parse(sayi2);

            Console.WriteLine(a+b);
            Console.ReadLine();*/

            //2.yöntem

            /*string sayi1 = "1";
            string sayi2 = "2";

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a + b);
            Console.ReadLine();*/

            //int veri tipinden string veri tipine dönüştürme

            /*int sayi1 = 5;
            int sayi2 = 10;

            string a =sayi1.ToString();
            string b =sayi2.ToString();

            Console.WriteLine(b+a);
            Console.ReadLine();*/

            //double veri tipinden int veri tipine dönüştürme

            /*double sayi1 = 5,22;

            int a = Convert.ToInt32(sayi1); //int veri tipine dönünce virgülden sonrası yok olur.

            Console.WriteLine(a);
            Console.WriteLine(sayi1.GetType()); //Veri tipini görmek için kullanırız.
            Console.ReadLine();*/

            //Kullanıcıdan alınan değerler string veri tipinde olur.

            /*Console.WriteLine("Lütfen Yaşınızı Giriniz?");
            
            string kullanici_yas=Console.ReadLine();

            int kullanici_yasInt=int.Parse(kullanici_yas);
            int kullanici_yasInt2=int.Parse(kullanici_yas);

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            Console.ReadLine();*/

            //Kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yazınız.

            /*Console.WriteLine("birinci sayiyi giriniz");
            string sayi1=Console.ReadLine();

            Console.WriteLine("ikinci sayiyi giriniz");
            string sayi2 = Console.ReadLine();

            int sayi1Int=int.Parse(sayi1);
            int sayi2Int=int.Parse(sayi2);

            Console.WriteLine("iki sayinin toplami:" + (sayi1Int + sayi2Int));
            Console.ReadLine();*/

            //ToString();
            //Convert.ToInt32();
            //int.Parse();
            //double.Parse();
            //(int);





        }
    }
}
