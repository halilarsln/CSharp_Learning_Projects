using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_ELSE_IF_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 not alan ve bu notların ortalamasını bulan bir kod yazacağız
            //Eğer 80-100 arasında A+ yazdıran
            //60-80 arasındaysa A yazdıran 
            //40-60 arasındaysa B+ yazdıran
            //40'dan küçükse F yazdıran örneğin kod parçalarını yazınız

            Console.WriteLine("Lütfen 1.notunuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not / 3);

            if (sonuc>80 &&sonuc<100)
                    { Console.WriteLine("Not Değeriniz:A+"); }
            else if (sonuc>60 && sonuc <80)
                    { Console.WriteLine("Not Değeriniz:A"); }
            else if(sonuc>40 && sonuc<60)
                    { Console.WriteLine("Not Değeriniz:B+"); }
            else
            { Console.WriteLine("Not Değeriniz:F"); }

            Console.ReadLine();

        }
    }
}
