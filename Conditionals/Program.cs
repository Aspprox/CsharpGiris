using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            // Asiignment operator: =
            // Arithmetic operator: +, -, *, /, %
            // Relational operator: ==, !=, <, >, <=, >=
            // Logical operator: &&, ||, ! 

            var number = 20;
            if (number == 10)  //durum kontrolü yapıyorsun.Eğer true ise alltaki süslü parantez içindeki bloğu çalıştırır.FALSE ise boş ekran gelir.

            {
                Console.WriteLine("Number is 10");
            }
            if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 20");
            }
            int n1, n2;
            n1 = 10;
            n2 = 20;

            if (n1 > n2) //iki kere taba basarsan syntax görebilirsin //Resharper
            {
                Console.WriteLine("n1 > n2");
            }
            else if (n1 < n2) 
            {
                Console.WriteLine("n1 < n2");
            } 
            else
            {
                Console.WriteLine("n1 = n2");
            }
            // if e alternatif olarak. ? ise. : değil ise
            string sonuc = n1 >= n2 ? n1 + " >= " + n2 : n1 + " < " + n2;
            Console.WriteLine(sonuc);


            var sayi = 100; // switch  ile değer göndermeliyiz ve durum belirtmeliyiz.
            switch (sayi)
            {
                case 10:
                    Console.WriteLine("Number is 10"); //önce var ile sayıyı belirledik.//Switch içine değer belirledik.
                    break;
                case 20:
                    Console.WriteLine("Number is 20"); //Caselerde olay şu 10 ise ne yazacağını belli ediyoruz break ise sayıyı yakalayınca devamını çalıştırmayıp çıkar.
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                default:
                    Console.WriteLine("Alakasız Sayı");  //en solda break point belirleyebiliriz.Sağ click add watch.F10 DEVAM.Switch if den daha performanslı.
                    break;
                   
            }


            Console.ReadLine();
        }
    }
}
