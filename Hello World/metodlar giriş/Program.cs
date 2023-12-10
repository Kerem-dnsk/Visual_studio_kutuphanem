using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_giriş
{
    class Program
    {
        static void Main(string[] args)
        {
            //parametresiz metod tanımlama .
            int tekrar_sayisi = 5; 
            for (int i = 0; i <= tekrar_sayisi; i++) // bu olmadı...
            {
                metot();
                i++;
            }


        }

        static void metot()
        {
            Console.WriteLine("diznler çok zor :(");
            Console.ReadLine();
        }
    }
}
