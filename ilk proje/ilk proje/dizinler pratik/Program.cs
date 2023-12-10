using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizinler_pratik
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakter = new char[5];
            
            for(int i = 0; i < karakter.Length; i ++)
            {
                Console.WriteLine("dizin içindeki " + i + " . indekse değer giriniz");
                karakter[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("*****************************************************");

            Console.Write("indeks değerleriniz = ");
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.Write(karakter[i]);
                
            }
            Console.ReadLine();


                

        }
    }
}
