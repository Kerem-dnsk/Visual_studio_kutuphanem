using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veya_operatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            // veya operatörü : ||

            int sayi1 = 3; //veya operatörü biri doğru diğeri yanlış olsa bile true döner.
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrloEt = sayi1 == sayi2 || sayi2 > sayi3;
            Console.WriteLine(kontrloEt);
            Console.ReadLine();

        }
    }
}
