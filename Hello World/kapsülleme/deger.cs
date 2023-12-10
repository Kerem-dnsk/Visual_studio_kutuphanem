using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme
{
    public class deger
    {
        private string isim;//private ile tanımladığın değerleri başka class'larda kullanmak için kapsülleme kullanılır
        public void setisim(string _isim) //set isim kalıplaşmış bir kelimedir ve isim çağırılıp "isim" değişkenine yazılır.
        {
            isim = _isim;
        }
        public string getisim() // getisim kalıplaşmış bir kelimedir ve çağırılan ismi yazdırır diğer class'a gidip bak
        {
            return isim; // bu işin amacı senin erişmek istediğin değere başkası erişemez... 

        }



    }

}

