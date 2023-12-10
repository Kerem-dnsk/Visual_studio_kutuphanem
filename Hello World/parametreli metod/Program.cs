using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametreli_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("çarpmak istediğiniz 3 sayının değerlerini giriniz");


            carpmaYap(   Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));




        }
        static void carpmaYap(int a, int b, int c)
        {
            Console.WriteLine("girdiğiniz değerlerin çarpımı = " + (a * b * c));
            Console.ReadLine();

        }

    }
}
