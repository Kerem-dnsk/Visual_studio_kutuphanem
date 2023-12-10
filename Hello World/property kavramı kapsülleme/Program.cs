using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_kavramı_kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 kilohesap = new Class1(); //kapsülleme yapacağında kullan ...
            kilohesap.kilo = 85; // prop yazıp tab tab basarsan sana yazdırıyo
            Console.WriteLine("kilonuz = "+ kilohesap.kilo);
            Console.ReadLine();
        }
    }
}
