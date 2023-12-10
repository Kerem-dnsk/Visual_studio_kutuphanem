using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_veri_tipi
{
    class Program
    {
        static void Main(string[] args)
        {
            float ondalikli_sayi1 = 55.43f; /*bir ondalıklı sayı belirttiğinizde sonuna "f" harfini koymalısınız çünkü program sayıy
                                             duble veri tipinde algılıyo f takısı sayıyı float veri tipine dönüştürmemizi sağlıyor*/
            float ondalikli_sayi2 = 12.9f;

            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);

            Console.ReadLine();
        }
    }
}
