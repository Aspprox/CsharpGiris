using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5]
            {
                "Ali", "Veli", "Can", "Mehmet", "Muhittin"
            };

            int i;
            for (i = 0; i < isimler.Length; i++)    //hiç bir zaman sabit sayı olarak yazma.Array kullanıp loop kullanıncadeğişiklik yaparsan 
                                                    //loop un düzgün çalışmaya devam edebilmesi için sabit sayı yerine lenght ile kullanıyoruz.
            {
                Console.WriteLine(i + ":" + isimler[i]);


            }
            Console.WriteLine("i son değer: " + i);  //loop tan çıktığı değeri görürsün.

            for (i = 1; i <= 10; i++) // 1 den 10 a kadar olan sayıları sıralar.
            {
                Console.WriteLine(i);
            }

            for (i = 1; i <= 10; i = i + 2)  //1 den 10 a kadar olan tek sayılar.
            {
                Console.WriteLine(i);
            }

            //for (i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            for (i = 10; i > 1; i = i - 2)  //0 dan geriye çift sayılar
            {
                Console.WriteLine(i);
            }

            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            int z = 1;
            while (z <= 10)
            {
                Console.WriteLine(z);
                z++; 
            }

            i = 10; //başlangıç değeri
            do
            {
                Console.WriteLine(i);
                i--; //değerin güncellenmesi
            } while (i >= 1);        //koşul kontrolü




            Console.ReadLine();
        }
    }
}
