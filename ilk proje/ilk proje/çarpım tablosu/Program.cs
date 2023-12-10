using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpım_tablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sayi1 = 1; sayi1 <= 10; sayi1++)
            {
                for (int sayi2 = 1; sayi2 <= 10; sayi2++)
                {
                    Console.WriteLine(sayi1 + "x" + sayi2 + "=" + (sayi1 * sayi2));
                }
            }
            Console.ReadLine();
        }
    }
}
