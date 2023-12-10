using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ve_operatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            // ve operatörü : &&

            int sayi1 = 4; // ve operatörü iki koşulda doğru ise true döner biri doğru biri yanlışsa folse döner.
            int sayi2 = 4;
            int sayi3 = 3;

            bool kontrolEt = sayi1 == sayi2 && sayi3 < sayi2;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
        
        } 

    }
}
