using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_veri_tipi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi = 5;           //byte değişkeni max "250" min "0" değerini tutabilir. 
            Console.WriteLine(sayi);

            byte maxDeger = byte.MaxValue; //MaxValue = byte'nin max değeri.
            Console.WriteLine(maxDeger);

            byte minDeger = byte.MinValue; //MinValue = byte'nin min değeri.
            Console.WriteLine(minDeger);

            Console.Read();
        }
    }
}
