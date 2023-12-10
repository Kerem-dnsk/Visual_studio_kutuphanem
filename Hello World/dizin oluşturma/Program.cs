using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizin_oluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4]; //sayilar adında bir dizin oluşturduk ve bunun 4 tane indeksi olduğunu gösterdik.
            sayilar[0] = 5; // burda indekslerin değerlerini atadık.
            sayilar[1] = 10;
            sayilar[2] = 15;
            sayilar[3] = 20;
            
            for (int i = 0; i < sayilar.Length; i++) 
            {
                Console.WriteLine(sayilar[i]); // diznlerin içindeki değerleri yazdırdık.
            }
            Console.ReadLine();

        }
    }
}
