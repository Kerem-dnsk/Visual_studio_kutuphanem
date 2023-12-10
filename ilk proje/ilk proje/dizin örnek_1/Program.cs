using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizin_örnek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 6, 7, 9, 1, 3, 2, 7, 0, 0, 0, 10, 10 };
                int sayi;
                int adet = 0;
                Console.WriteLine("dizinde aratmak istediğiniz bir değer girin");
                sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayi == sayilar[i])
                    {
                        adet++;
                    }


                }
                if (adet == 0)
                {
                    Console.WriteLine("girdiğiniz değer dizin'de bulunamadı.");
                }
                else
                {
                    Console.WriteLine("girdiğiniz değer dizinde bululndu.");
                    Console.WriteLine("adet: " + adet);
                }
                Console.ReadLine();
            }
        }

    }
}
