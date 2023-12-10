using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_pratik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            float ortalama = toplam / sayi ;
            if (ortalama < 50)
            {
                Console.WriteLine("girdiğiniz sayı ="+sayi);
                Console.WriteLine(sayi+" sayısından 1'e kadar olan sayıların toplamı ="+toplam);
                Console.WriteLine("aritmetik ortalamanız =" + ortalama);
                Console.WriteLine("girdiğiniz sayının ortalaması 50'den küçük");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı =" + sayi);
                Console.WriteLine(sayi + "sayısından 1' kadar olan sayıların toplamı =" + toplam);
                Console.WriteLine(" aritmetik ortalamanız =" + ortalama);
                Console.WriteLine("girdiğiniz sayının ortalaması 50'den büyük");
                Console.ReadLine();
            }
        }
    }
}
