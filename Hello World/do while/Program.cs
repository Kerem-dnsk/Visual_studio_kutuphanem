using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            int toplam = 0;
            do
            {
                toplam += sayi;
                sayi++;
            } while (sayi<=100);
            Console.WriteLine("100'e kadar olan sayıların toplamı"+toplam);
            Console.ReadLine();

        }
    }
}
