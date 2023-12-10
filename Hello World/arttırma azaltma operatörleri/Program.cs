using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arttırma_azaltma_operatörleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //arttırma operatörü = ++
            //azaltma operatörü = --

            int sayi = 45;

            sayi++;
            Console.WriteLine(sayi); //kodlar sırayla gittiği için saıyı azalttığımda 44 değil 45 oldu üstte sayıyı 1 arttırdık sonra azalttık 46-1=45.

            sayi--;
            Console.WriteLine(sayi);

            Console.ReadLine();
            Console.WriteLine("a+=2");

        }
    }
}
