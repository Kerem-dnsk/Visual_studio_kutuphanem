using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lar_giriş
{
    public class araba
    {
        public int kapisayisi;
        public string arabaModeli;
        public string arabaRengi;

        public araba(int kapiSayisi_, string arabaModeli_, string arabaRengi_)
        {
            kapisayisi = kapiSayisi_;
            arabaModeli = arabaModeli_;
            arabaRengi = arabaRengi_;

        }
        public void kapiKilidi()
        {
            Console.WriteLine(" kapılar kilitleniyor...");
        }
        public void motor()
        {
            Console.WriteLine("motor çalıştırılıyor...");
        }
    }

}
