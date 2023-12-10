using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_proje_önemli
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1, "kerem", "danışık", 70, 60, 50, "Konya Lisesi");
            while (kontrol)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("uygulamaya hoşgeldiniz...");
                islemler();

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriniGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.OgrenciOrtalamasiBul();
                        Console.WriteLine("öğrenci ortalama = " + ogrenciOrtalama);
                        break;
                    case "3":
                        ogrenci1.OkulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;


                }
            }
        }
        static void islemler()
        {
            // işlemleri metodda tanımladık ve görüntü kalabalığpını önledik.
            Console.WriteLine("öğrencinin bilgilerini görmek için 1'i,");
            Console.WriteLine("öğrencinin ortalamasının görmek için 2'yi,");
            Console.WriteLine("öğrencinin okulunu görmek için 3'ü,");
            Console.WriteLine("çıkış yapmak için 4'ü tuşlayınız...");

        }// işlemleri metodda tanımladık ve görüntü kalabalığını önledik.
    }
}
