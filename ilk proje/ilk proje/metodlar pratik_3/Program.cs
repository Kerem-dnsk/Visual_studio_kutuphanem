using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_pratik_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 2 değer al hangisinin büyük yada küçük olduğunu bul.
            while (true)
            {
                Console.Write("1. değeri giriniz = ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. değeri giriniz = ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                sayi_kontrol(sayi1, sayi2);
                Console.ReadLine();
            }
        }
        static void sayi_kontrol(int deger1, int deger2)
        {
            if(deger1<deger2)
            {
                Console.WriteLine(deger1+" sayısı "+deger2+" sayısından küçüktür"); 
            }
            else if(deger1 == deger2)
            {
                Console.WriteLine(deger1+" sayısı "+deger2+" sayısına eşittir");
            }
            else
            {
                Console.WriteLine(deger1+ " sayısı "+deger2+" sayısından büyüktür");
            }
        }

    }
}
