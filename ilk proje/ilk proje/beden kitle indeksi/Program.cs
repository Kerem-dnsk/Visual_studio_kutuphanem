using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_indeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl+K+D KODU DÜZENLER.
            Console.WriteLine("beden kitle indeksinizi öğrenmek için;");
            Console.WriteLine("kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("beden kitle indeksiniz" + bke);
                Console.WriteLine("zayıfsınız");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("beden kitle indeksiniz" + bke);
                Console.WriteLine("normalsiniz");
                Console.ReadLine();
            }
            else if (bke > 25)
            {
                Console.WriteLine("beden kitle indeksiniz" + bke);
                Console.WriteLine("obezsiniz");
                Console.ReadLine();
            }

        }
    }
}
