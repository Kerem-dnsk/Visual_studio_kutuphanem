using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapıcı_meyod
{
   public class kullanıcı
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }

        private string soyisim { get; set; }
      static  private int maas { get; set; } //static yapıcı metodda kullanmak için değişkenide static tanımlamalıyız...

        static  kullanıcı() // "ctor" yaazıp tab tab yapmak bize yapıcı metodu otomatik oluşturur..
        {
            maas = 1000;
            
        }

        



    }
}
