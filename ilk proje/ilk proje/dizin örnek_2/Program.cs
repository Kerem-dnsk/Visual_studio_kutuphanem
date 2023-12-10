using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizin_örnek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 10 adet değer al
            //değerlerin tek ve çift adetlerini yaz
            // tek ve çift değerlerin toplamını yaz
            //sonra kontrol et eğer tek sayıların toplamı çift sayıların toplamından büyükse : tek sayıların toplamı çift sayıların toplamından büyüktür yazdır 
            // yada tamm tersi..
            int[] degerler = new int[10];
            int tek_adet = 0;
            int çift_adet = 0;
            int çift_toplam = 0;
            int tek_toplam = 0;

            int kullanici_degeri;
            for (int i = 0; i < degerler.Length; i++) 
            {
                Console.Write((i+0)+". index değerini giriniz = ");
                kullanici_degeri = Convert.ToInt32(Console.ReadLine());
                degerler[i] = kullanici_degeri;
            }
       for(int j = 0; j< degerler.Length; j++)
            {
                if(degerler[j]%2 == 0)
                {
                    çift_adet++;
                    çift_toplam += degerler[j];
                }
                else
                {
                    tek_adet++;
                    tek_toplam += degerler[j];
                }


            }
            
            Console.WriteLine("***************************************");
            Console.WriteLine("çift değerlerin toplamı = "+çift_toplam);
            Console.WriteLine("çift değerlerin adedi = "+çift_adet);
            Console.WriteLine("***************************************");
            Console.WriteLine("tek değerlerin toplamı = "+tek_toplam);
            Console.WriteLine("tek değerlerin adedi = "+tek_adet);
            Console.WriteLine("***************************************");
            if (çift_toplam < tek_toplam)
            {
                Console.WriteLine("tek sayıların toplamı çift sayıların toplamından büyüktür");
            }
            else
            {
                Console.WriteLine("çift sayıların toplamı tek sayıların toplamından büyüktür");
            }
              Console.ReadLine();
        
        
        }
    }
}
