using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.proje
{
    class Program
    {
        static void Main(string[] args)
        {
            //string veri tipini int veri tipine dönüştürme...

            Console.WriteLine("bir sayı giriniz");
            string sayi = Console.ReadLine();

            double a = Convert.ToDouble(sayi);
            Console.WriteLine("girdiğiniz sayının küpü = "+ (a * a *a ));

            Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------
            
            //byte veri tipini int veri tipine dönüştürme.
           /* byte x = 4 ;
            int y = Convert.ToByte(x);
            Console.WriteLine(y.GetType());
            Console.WriteLine(x);

            Console.ReadLine();*/

            // çalıştıracağın projenin /*'ını kaldır.
            




        }
    }
}
