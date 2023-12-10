using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lar_giriş
{
    class Program
    {
        static void Main(string[] args)
        {
            // public = bütün classlara açık olan kullanılabilen bir erişim kelimesidir
            //private = sadece kendi clası içinde erişimi olan bir kelimedir. araba klass'ını açıp bak...
            araba araba1 = new araba(4, "skoda","kırmızı");
            
            araba1.kapiKilidi();
            araba1.motor();
            Console.WriteLine("araba rengi = "+araba1.arabaRengi);
            Console.WriteLine("arabanın kapı sayısı = "+araba1.kapisayisi);
            Console.WriteLine("arabanın modeli = "+araba1.arabaModeli);
            Console.ReadLine();
        }
    }
}
