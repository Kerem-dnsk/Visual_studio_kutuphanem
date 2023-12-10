using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int toplam = 0;
                Console.WriteLine("bir sayı giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <=a; i++)
                {
                    toplam += i;
                    
                }
                Console.WriteLine(a + "dan 1'e kadar olan sayıların toplamı =" + toplam);
                Console.ReadLine();


            }
        }
    }
}
