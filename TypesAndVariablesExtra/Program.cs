using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariablesExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 1;  //ikisi aynı sondaki örenkelerine takılma!
            Int32 sayi2 = 2;


            long sayi3 = 3;
            Int64 sayi4 = 4;

            bool durum1 = false;
            Boolean durum2 = true;

            string AdSoyad = "\"Çağıl Alsaç\""; //tırnak içinde bir şey yazmak istersen
            Console.WriteLine(AdSoyad);

            string path = "C:\\BilgeAdam\\CsharpGiris";  // \ bir escape karakter olduğu için kafası karışıyor.Bu nedenle \ ın yanına yine ekliyoruz.
            path = @"C:\BilgeAdam\CsharpGiris"; // \ kullanmak yerine böyle verilere özel @ kullanabiliyoruz.
            Console.WriteLine(path);

            //Özel Karakterler-Escape Karakterler
            //    1-) Çift Tırnak : \*
            //    2-) Slash: \\
            //    3-) New Line : \n (Alt satır)
            //    4-) Carriage Return : \r (Satır Başı)
            //    5-) Tab: \t bastığın boşluk kadar yer açar ve oradan yazmaya başlar.

            //Mantıksal Tip (Doğruluk Tip)
            bool deger1 = true;
            bool deger2 = false;
            bool sonucOr = deger1 || deger2; // || or
            Console.WriteLine("Deger1: " + deger1 + "Or Deger2: " + deger2 + " = " + sonucOr);
            bool sonucAnd = deger1 && deger2; // && and
            Console.WriteLine("Deger1: " + deger1 + "And Deger2: " + deger2 + " = " + sonucAnd);

            //Onermeler
            //p   q   p && q  (ve-and)
            //1   1   1
            //1   0   0
            //0   1   0
            //0   0   0

            //p   q   p || q  (veya-or)
            //1   1   1
            //1   0   1
            //0   1   1
            //0   0   0



            Console.ReadLine();

        }
    }
}
