using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            deger isim1 = new deger();
            isim1.setisim("kerem");

            Console.WriteLine(isim1.getisim());
            Console.ReadLine();

        }
    }
}
