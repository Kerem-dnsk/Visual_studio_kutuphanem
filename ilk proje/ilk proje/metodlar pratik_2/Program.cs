using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_pratik_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz");
            int kullaniciDegeri = Convert.ToInt32(Console.ReadLine());
            tekmiCiftmi(kullaniciDegeri);
            Console.ReadLine();
        }
        static void tekmiCiftmi(int sayi)
        {
            if(sayi%2 == 0)
            {
                Console.WriteLine("girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı tekdir");
            }
        }
    }
}
