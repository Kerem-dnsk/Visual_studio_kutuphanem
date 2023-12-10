using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 3;
            while (true)
            {
                Console.WriteLine("lütfen kullanıcı adınızı giriniz");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("lütfen şifrenizi giriniz");
                string sifre = Console.ReadLine();
                
                if(kullaniciAdi =="kerem" && sifre =="3237" )
                {
                    Console.WriteLine("başarılı bir şekilde giriş yaptını");
                    Console.ReadLine();
                    break;
                }
           else
                {
                    Console.WriteLine("kullanıcı adı veya şifre hatalı");
                    if(hak_sayisi>0)
                    {
                        hak_sayisi -= 1;
                    }
                    if(hak_sayisi == 0)
                    {
                        Console.WriteLine("hatalı giriş yaptınız ve bloke edildiniz :(");
                        Console.ReadLine();
                        break;
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
