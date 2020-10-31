using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Çağıl";  // bu şekilde de kullanabilirsin ama bu bir küme ve bunu bir dizi olarak kullanabilirsin.
            string student2 = "Leo";  // [] yeni bir dizi oluştururken nwe kullanıyoruz.
            string student3 = "Angel";

            string[] students = new string[3]; // 3 ile eleman sayısı yani bir sınır belirttik.
            students[0] = "Çağıl";  //new dediğin zaman array memoryde oluşacak
            students[1] = "Leo";
            students[2] = "Angel";

            int[] numbers = new[] 
            {
               1,
               2,
               3,
               4,
            };


            decimal[] decimals = new decimal[3]
             {
                1.1M,
                2.2M,
                3.3M,
             };

            char[] characters = { 'C', 'E', 'N', 'K' };    // her zaman 4 elemanlı için kullanmalısın.//kendi new ledi.

            //characters = new char[] { 'C', 'E', 'N', 'K', 'Ç' };
            //Console.WriteLine(characters[4]);  // normalde 4 karakteriçin açıldı ama biz new dediğimiz zaman aradaki bağlantıyı k
            //kesiyor ve yeni tabloyla bağlantı kuruyor.

            //Console.Write(characters[0]);
            //Console.Write(characters[1]);
            //Console.Write(characters[2]);
            //Console.Write(characters[3]);

            foreach (char character in characters)
            {
                Console.Write(character);
            }

            //multi dimensoal arrays
            string[,] bolgelerVeSehırler = new string[4, 2]  //4 satır 2 sütun 
            {
                { "İç Anadolu", "Ankara" },
                { "Marmara", "İstanbul" },
                { "Ege" , "İzmir" },
                { "Doğu Anadolu", "Van" }
            };
            //bolgelerVeSehırler[0, 0] = "İç Anadolu";
            //bolgelerVeSehırler[0, 1] = "Ankara";
            //bolgelerVeSehırler[0, 0] = "Marmara";
            //bolgelerVeSehırler[0, 0] = "İstanbul";

            foreach (string bolgeVeSehir in bolgelerVeSehırler) //foreach döngü yapmanın bi yolu.
            {
                Console.WriteLine(bolgeVeSehir);
            }

            for (int i = 0; i <= 3; i++) //orta kısım koşul yani bu döngü hafi koşul 0 olana kadar çalışacak.
                //i++ : i = i + 1      : i += 1 
            {
                Console.WriteLine("Bölge: " + bolgelerVeSehırler[i, 0] + ",Sehir: " + bolgelerVeSehırler[i, 1]);
            }


            Console.ReadLine();
        }
    }
}
