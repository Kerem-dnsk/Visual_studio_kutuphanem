using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_proje_önemli
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsim;

        public Ogrenci(int _ogrenciNo , string _isim , string _soyisim , int _vize1 , int _vize2 , int _final , string _okulIsim)//yapıcı metod tanımladık...
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsim = _okulIsim;
        }

        public void ogrenciBilgileriniGoster()
        {
            Console.WriteLine("öğrenci NO = "+ogrenciNo);
            Console.WriteLine("öğrenci ismi = "+isim);
            Console.WriteLine("öğrenci soyismi = "+soyisim);
            Console.WriteLine("öğrencinin 1. vize notu = "+vize1);
            Console.WriteLine("öğrencinin 2. vize notu = " + vize2);
            Console.WriteLine("öğrencinin final notu = " + final);
        }
        public double OgrenciOrtalamasiBul()
        {
           double  ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }
        public void OkulGetir()
        {
            Console.WriteLine("öğrencinin okulu = "+okulIsim);
        }
    }
}
