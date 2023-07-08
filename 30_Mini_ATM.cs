using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Mini_Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya nasıl işlem yapmak istediğini soracağız
            //1 tuşuna bastığımızda bakiye görüntüleme
            //2 tuşuna bastığımızda Para Çekme
            //3 tuşuna bastığımızda Para Yatırma
            //q tusuna bastığımızda çıkış yapıracağız.

            int bakiye = 1000;

            Console.WriteLine("Atm'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi şeçiniz");
            String secim =Console.ReadLine();

            if (secim == "1") 
            { 
                Console.WriteLine("Şuanki Bakiyeniz:"+bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar=Convert.ToInt32(Console.ReadLine());

                if(cekilecek_tutar<=bakiye)
                {
                    Console.WriteLine("Kalan Tutar:" + (bakiye - cekilecek_tutar)) ;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                    Console.ReadLine();
                }

            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatirilacak_tutar=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz:"+(bakiye+yatirilacak_tutar));
                Console.ReadLine();

            }
            else if(secim == "q") 
            {
                Console.WriteLine("ATM'den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı İyi Günler....");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();
            }
        }
    }
}
