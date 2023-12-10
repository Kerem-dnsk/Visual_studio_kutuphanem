using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizin_oluşturma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "kerem", "danışık", "ender", "şerife", "berna" }; // string tipinde diziler oluşturula bilir verieri çift tırnak içinde yazılır.
            double[] sayilar = { 1.23, 1.34, 5.45 }; // double tipinde dizinler oluşturulabilir.
            char[] karakterler = { 'k', 'e', 'r', 'm' }; // char tipinde dizinler oluşturulabilir, verileri tek tırnak içinde yazılır.

            for (int i = 0; i < isimler.Length; i ++)// hangi değerleri yazdırmak istiyorsan onun değişkenini yaz.
            {
                Console.WriteLine(isimler[i]);
                
            }
            Console.ReadLine();
        }
    }
}
