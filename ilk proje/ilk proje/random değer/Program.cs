using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_değer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("rastgele seçilen sayılar = ");
            Console.WriteLine("*********************************");


            Random deger = new Random();
            int random_deger = deger.Next(0, 50);
            int random_deger2 = deger.Next(0, 50);
            int random_deger3 = deger.Next(0, 50);

            Console.Write("sayı1= {0} // sayı2= {1} // sayı3= {2} ", random_deger , random_deger2 , random_deger3);
            

            Console.ReadKey();
        }
    }
}
