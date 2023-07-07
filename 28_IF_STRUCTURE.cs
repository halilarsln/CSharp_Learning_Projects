using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_IF_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrencinin notu 50'den büyükse başarılı değilse başarısız yazdıran program çıktısını kodlayınız.

            int not = 75;

            if (not>50)
            { Console.WriteLine("Ögrenci bu dersten başarılı bir şekilde geçmiştir."); }
            else { Console.WriteLine("Dersten başarısız oldun"); }
            Console.ReadLine();
        }
    }
}
