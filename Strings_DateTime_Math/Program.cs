using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1 = "Ankara";
            Console.WriteLine(city1[0]);   //A 
            foreach (var karakter in city1)
            {
                Console.WriteLine(karakter);    // Har harf yukarıdan aşağıya Ankara yazdırır.
            }

            string city2 = "İstanbul";
            string result1 = city1 + " " + city2;  //result değişken ismi istediğin gibi isimlendirebilirsin
            Console.WriteLine(result1);    // Ankara İstanbul şeklinde yazar. concatenate
            string result2 = string.Format("{0} {1}", city1, city2); //aynı işlevi görüyor ancak format
            Console.WriteLine(result2);  //ile kullanmak daha mantıklı

            string sentence = "My name is Çağıl Alsaç";//.Length;
            int lenght = sentence.Length;  //22
            Console.WriteLine(lenght);

            Console.WriteLine("".Length); //0 çünkü null string içinde hiçbir eleman olmadığı için 0

            sentence = sentence.Replace("Çağıl", "Leo");  //çağıl gördüğü yeri leo yapıyor.
            Console.WriteLine(sentence);

            if (sentence.EndsWith("aç"))  //belirttiğin ile bitiyorsa
                Console.WriteLine("aç ile bitiyor");
            else
                Console.WriteLine("aç ile bitmiyor");

            if (sentence.StartsWith("My"))  //başlıyorsa
            {
                Console.WriteLine("My ile başlıyor.");
            }
            else
            {
                Console.WriteLine("My ile başlıyor.");
            }

            int indexOfIs = sentence.IndexOf("is");  //aradığın kısmın indexini verir.Bu örnek için i nin
            // indexini verir. //olmayan bir şey aratırsan -1 döner
            Console.WriteLine(indexOfIs);

            //string sentence1 = "My name is Ozan Cem Yeşil";

            //int indexOfÇ = sentence.IndexOf("ç");
            //Console.WriteLine(indexOfÇ);

            Console.WriteLine(sentence.IndexOf(" ")); //boşluğu ilk bulduğu indexi verir
            Console.WriteLine(sentence.LastIndexOf(" ")); //sondan ilk boşluk indexi

            sentence = sentence.Insert(0, "Hello! ");  //belirttiğin index ksımına ekleme yapmanı sağlar.


            string subSentence = sentence.Substring(18); //belirttiğim yerden başla sonuna kadar al
            //Leo Alsaç 
            Console.WriteLine(subSentence);

            subSentence = sentence.Substring(18, 3); // Leo yu alır.
            Console.WriteLine(subSentence);

            Console.WriteLine(sentence.ToLower() + " - " + sentence.ToUpper());
            //to lower kelimenin bütün harflerini küçültür toupper ise büyütür.

            //Hello! My name is Leo Alsaç
            Console.WriteLine(sentence.Replace(" ", "_"));  // boşlukları _ ye dönüştürür.
            sentence = sentence.Remove(5, 1);  //ünlemi kaldırır ama 1 olmazsa ünlmele beraber sonrasını da 
            sentence = sentence.Insert(5, "*");// uçurur. ! yerine * ekledik.
            Console.WriteLine(sentence);

            //Hello* My name is Leo Alsaç
            string[] words = sentence.Split(' ');  //split belirttiğimiz kısma göre parçalar.
            foreach (var word in words) // array yaptık çünkü parçalarımız var. 
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(words[4]); //Leo  //4. indexdeki kelimeyi getirdik.

            string test1 = "test1";
            string test2 = "test2";

            if (test1 == test2)
            {
                Console.WriteLine("test1 = test2");
            }
            else
            {
                Console.WriteLine("test1 != test2");
            }

            if (test1.Equals(test2)) // eşitliği bu şekildede deneyebiliyoruz
            {
                Console.WriteLine("test1 = test2");
            }
            else
            {
                Console.WriteLine("test1 != test2");
            }

            string ad = " Çağıl Alsaç ";  //herhangi bir stringin başındaki ve sonundaki boşlukları uçur.
            Console.WriteLine(ad.Trim());
            Console.WriteLine(ad.TrimEnd()); //sondaki boşluğu temizler
            Console.WriteLine(ad.TrimStart()); //baştaki boşluğu siler.
            //HackerRank

            //escape characters,escape sequences
            string name = "Çağıl";
            Console.WriteLine("\"Çağıl\"");  // tırnak içinde yazmanı sağlar
                                             //Console.WriteLine("\"" + name + "\""); alternatif

            string surname = "Alsaç";
            string nameSurname = name + "\n" + surname;  //new line  // alt alta yazar.
            Console.WriteLine(nameSurname);

            nameSurname = name + "\t" + surname; // Çağıl   Alsaç // tab kadar boşluk bırakır.
            Console.WriteLine(nameSurname);

            string path = "C:\\BilgeAdam\\CsharpGiris";
            path = @"C:\BilgeAdam\CsharpGiris";



            Console.ReadLine();



        }
    }
}
