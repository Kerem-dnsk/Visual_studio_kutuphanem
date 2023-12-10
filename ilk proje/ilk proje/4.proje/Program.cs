using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("öğrencinin dönem sonu ortalamasını girin");
            int ortalama = Convert.ToInt32(Console.ReadLine());

            if (ortalama <= 100 && ortalama >= 85)
            {
                Console.WriteLine("öğrencinin karnesi pekiyi :)");
                Console.ReadLine();
            }
            else if (ortalama <= 84 && ortalama >= 75)
            {
                Console.WriteLine("öğrencinin karnesi iyi :)");
                Console.ReadLine();
            }
            else if (ortalama <= 74 && ortalama >= 50)
            {
                Console.WriteLine("öğrencinin karnesi kötü :/");
                Console.ReadLine();
            }
            else 
                    {
                Console.WriteLine("öğrencinin karnesi çok kötü :( ");
                Console.ReadLine();
            }

        }
    }
}
