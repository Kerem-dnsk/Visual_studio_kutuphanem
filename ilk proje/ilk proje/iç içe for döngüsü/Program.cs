using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iç_içe_for_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 40; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(b);
                   
                }
                Console.WriteLine("");
                
            }
            Console.ReadLine();
        }

    }
}
