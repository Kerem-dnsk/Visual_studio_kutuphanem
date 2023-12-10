using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ugulaması_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 3000;
            Console.WriteLine("ATM'ye hoşgeldiniz.");
            Console.WriteLine("Bakiyenizi öğrenmek için: 1'i");
            Console.WriteLine("para çekmek için 2'yi");
            Console.WriteLine("para yatırmak için 3'ü");
            Console.WriteLine("çıkış yapmak için 4'Ü tuşlayınız...");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz" + bakiye);
                    Console.ReadLine();
                    
                case "2":
                    Console.WriteLine("çekilecek tutarı girin");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("bakiyenizden fazla para çekemezsiniz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("yeni bakiye" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("yatırmak istediğiniz tutarı girin");
                    int yit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni bakiye" + (bakiye + yit));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("çıkış yapılıyor...");
                    Console.WriteLine("bizi tercih ettiiğiniz için teşekkürler :)");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("lütfen geçerli değer giriniz");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
