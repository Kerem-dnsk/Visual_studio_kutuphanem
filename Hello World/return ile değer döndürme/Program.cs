using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_ile_değer_döndürme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toplamak istediğiniz 2 değeri giriniz: ");
            int dönenDeğer = toplamaYap(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            if(dönenDeğer<10)
            {
                Console.WriteLine("sonuç 10 dan küçüktür");
            }
            else
            {
                Console.WriteLine("sonuç 10 dan büyüktür");
            }
            Console.ReadLine();
        }

        static int toplamaYap (int sayi1 , int sayi2 )
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
       // static string isimSoyisim (string isimi , string soyisim)
        //{
          //  string deger = isimi + " " + soyisim;

        //}
    }
}
