using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_veri_tipi
{
    class Program
    {
        static void Main(string[] args)
        {
            short maxDeger = short.MaxValue; //short veri tipi max 32.767 min -32.768 değerini alabilir.
            short minDeger = short.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
        }

    }
}
