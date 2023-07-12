using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Login_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı giriş sayfası uygulaması yapacağız
            //kullanıcı adı ve şifresini doğru girerse Tebrikler başarılı bir şekilde giriş yaptınız
            //yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcıya yanlış girdiği sürece dögü dönmeye devam etsin

            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adını giriniz");
                string kullaniciAdi=Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz");
                string sifre=Console.ReadLine();

                if (kullaniciAdi=="halil" && sifre == "123")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış!");

                    if (hak_sayisi > 0)
                    {
                        hak_sayisi -=1;
                    }
                    if (hak_sayisi==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur bir daha giriş yapamazsınız");
                        break;
                    }
                    

                   
                }
            }
            Console.ReadLine();
        }
    }
}
