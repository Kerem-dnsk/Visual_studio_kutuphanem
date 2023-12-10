using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renkli__console
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.Clear();
            while (true)
            {
                int[] sayilar = { 1, 3, 5, 7, 2, 9, 4, 6, 9, 8, 11, 13, 15, 12, 10, 14 };
                for (int i = 0; i < sayilar.Length; i++)
                {
                    ConsoleColor renk = (ConsoleColor)sayilar[i];
                    Console.ForegroundColor = renk;
                    Console.Write("--");
                    
                                           


                    Console.ReadKey();

                }
               
            }
        }
    }
}
