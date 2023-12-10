using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama_çıkarma_operatörleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // toplama operatörü = +
            // çıkarma operatörü = -

            int sayi1 = 10;
            int sayi2 = 17;
            int sayi3 = 2;

            int sayi4 = 31;

            int sonuç = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuç);
            Console.ReadLine();



        }
    }
}
