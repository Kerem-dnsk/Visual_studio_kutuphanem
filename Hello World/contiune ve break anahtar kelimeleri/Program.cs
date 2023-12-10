using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contiune_ve_break_anahtar_kelimeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {

                if (a == 7)
                {
                    continue; // contiune yazarsan istemediğin değeri tek seferlik yazmaz sonra for devam ediyorsa geriye kalan verileri ekrana yazar
                    //break koyarsak ve istemediğimiz değer belirtirsek istemediğimiz değere kadar ekrana verileri yazar ve sonrasını kırar buyüzden kod devam etse bile verileri ekranda görmeyiz.
                }
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
