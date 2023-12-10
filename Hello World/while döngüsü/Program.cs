using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50; //bu 50'den 0'a kadar olan değerlerin çift olanlarını ekrana yazdırdı.
            while (a >= 0)
            {
                Console.WriteLine(a);
                a -= 2;
            }
            Console.ReadLine();
        }
    }
}
