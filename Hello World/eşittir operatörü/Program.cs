using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşittir_operatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            //eşittir operatörü = ==
            int sayi1 = 4;
            int sayi2 = 4;
            int sayi3 = 5;
            bool kontrolEt = sayi1 == sayi2;
            Console.WriteLine(kontrolEt);

            bool kontrolEt2 = sayi2 == sayi3;
            Console.WriteLine(kontrolEt2);
            Console.ReadLine();
        }
    }
}
