using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList rakamlar = new ArrayList(); // arraylist dizinlerin daha karmaşık ama kullanışlı halidir. bu şekilde kullanılır ve üstte kütüphanesi tanımlanır
            rakamlar.Add("kerem"); //add anahtar kelimesi değer ekler
            rakamlar.Add("danışık");
            rakamlar.Remove("danışık");//remove dizindeki değeri siler.
            foreach (string a in rakamlar)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            // bunların dışında count , indexof , insert , reverse gib kelimelerde kullanılır


        }
    }
}
