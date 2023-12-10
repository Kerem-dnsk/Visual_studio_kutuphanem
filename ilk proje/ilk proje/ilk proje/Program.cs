using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayı girin");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("girdiğiniz sayıların toplamı :");
            Console.Write(a + b);

            Console.ReadLine();

        }
    }
}
