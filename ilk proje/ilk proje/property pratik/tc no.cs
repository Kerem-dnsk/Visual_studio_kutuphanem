using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_pratik
{
    public class tc_no
    {
        private string deger;
        public int tcNo
        {
            get
            {
                return deger;
            }
            set
            {
                if(tcNo.Length == 11)
                {
                    for(int i = 0; i<=tcNo.Length;i++)
                    {
                        bool sayımı = char.IsNumber(Convert.ToChar(i));
                        if (sayımı == true)
                        {

                        }
                        else 
                        {
                            
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("tc no 11 karakter değil...");
                }
            }
                



        }
    }
}
