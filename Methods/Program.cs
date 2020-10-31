using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string adSoyad; //camel case değişken tanımlanırken ilk harf küçük
            DisplayName();
            DisplayNameByParameter("ç");
            DisplayNameByParameter("f");
            int s1 = 10;
            short s2 = 20;
            AddTwoNumbers(s1, s2);
            int carpim = MultiplayTwoNumbers(s1, s2);
            Console.WriteLine("Çarpım = " + carpim);
            Console.WriteLine(GetPi()); 

            Console.ReadLine();
        }


        static void DisplayName() //Pascal case 
        {
            Console.WriteLine("Çağıl Alsaç");
        }

        static void DisplayNameByParameter(string ad)
        {
            if (ad == "ç")
                Console.WriteLine("*Çağıl Aslaç*");
            else
                Console.WriteLine("Furkan Doğan");
        }

        static void AddTwoNumbers(int sayi1, short sayi2)
        {
            long toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1 + sayi2);
        }

        static int MultiplayTwoNumbers(int sayi1, int sayi2)
        {
            int sonuc;
            sonuc = sayi1 * sayi2;  //bir metoda birden çok iş yükleme!
            return sonuc; 
        }

        static double GetPi()
        {
            return 3.14;
        }

    }
}
