using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = { 1, 2, 3, 4 };
            foreach (int a in sayi) // "foreach" dizinlerin içindeki değerleri daha kolay bir şekilde ekrana yazdırmaya yarar.
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
