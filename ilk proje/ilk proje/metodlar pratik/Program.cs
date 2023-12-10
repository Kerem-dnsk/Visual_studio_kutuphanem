using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_pratik
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("karesini hesaplamak istediğiniz sayıyı girin : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int karesi = kare(sayi);
                if (karesi < 50)
                {
                    Console.WriteLine("sonuç =  " + karesi);
                    Console.WriteLine("sonuç 50 den küçüktür");
                }
                else
                {
                    Console.WriteLine("sonuç = " + karesi);
                    Console.WriteLine("sonuç 50 den büyüktür");
                }
                Console.ReadLine();
            }
        }
        static int kare(int a)
        {

            return a * a;

        }
    }
}
