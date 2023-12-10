using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_pratik
{
    class Program
    {
        static void Main(string[] args)
        {
            tc_no personelTc = new tc_no();
            Console.WriteLine("TC'nizi giriniz...");
            personelTc.tcNo =Convert.ToInt32( Console.ReadLine());
        }
    }
}
