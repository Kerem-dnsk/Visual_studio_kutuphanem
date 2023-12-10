using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 3000;



            while (true)
            {
                Console.WriteLine("ATM'ye hoşgeldiniz.");
                Console.WriteLine("Bakiyenizi öğrenmek için: 1'i");
                Console.WriteLine("para çekmek için 2'yi");
                Console.WriteLine("para yatırmak için 3'ü");
                Console.WriteLine("çıkış yapmak için 4'ü tuşlayınız...");
                string secim = Console.ReadLine();



                if (secim == "1")
                {
                    Console.WriteLine("bakiyeniz " + bakiye);
                    Console.ReadLine();

                }
                else if (secim == "2")
                {


                    Console.WriteLine("çekilecek değeri girin");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar <= bakiye)
                    {
                        Console.WriteLine("kalan tutar" + (bakiye - tutar));
                        bakiye = bakiye - tutar;
                        Console.ReadLine();
                    }
                    else
                    {

                        Console.WriteLine("bakiyenizden fazla para çekemezsiniz.");
                        Console.ReadLine();
                    }

                }
                else if (secim == "3")
                {
                    Console.WriteLine("yatırılacak tutarı girin");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni bakiye =" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("bizi tercih ettiğiniz için teşekkürler :)");
                    Console.WriteLine("çıkış yapıldı...");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("lütfen geçerli bir değer giriniz");
                        Console.ReadLine();
                        break;
                    }
                }
            }
           

        }

    }
}
