using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz :");
            string sayi = Console.ReadLine();
            int sayiInt = Convert.ToInt32(sayi);
            if (sayiInt<100)
            {
                Console.WriteLine("girdiğiniz sayı 100 den küçük");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("girdiğiniz sayı 100 den büyük");
                Console.ReadLine();
            }
        }
    }
}
