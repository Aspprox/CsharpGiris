using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayi: ");
            string giris = Console.ReadLine();
            int sayi1 = Convert.ToInt32(giris);
            Console.WriteLine("2. sayi: ");
            giris = Console.ReadLine();
            int sayi2 = int.Parse(giris); //int sayi1 = Convert.ToInt32(giris); aynı işlev
            Console.WriteLine("3. sayi: ");
            giris = Console.ReadLine();
            int sayi3 = Int32.Parse(giris); //üç kısımda sayıların 1. 2. veya 3. olması hariç her kısım aynı işi yapıyor.
            if (sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3) //sayı örnekleri vererek düşün.
            {
                Console.WriteLine("Tüm sayılar eşit.");

            }
            else // sayi 1 != sayi2 || sayi1 != sayi3 || sayi2 != sayi3 
            {
                int EnBuyukSayi = sayi1;
                if (sayi2 >= sayi1)
                {
                    if (sayi2 >= sayi3)
                    {
                        EnBuyukSayi = sayi2;
                    }
                }
                if (sayi3 >= sayi2 && sayi3 >= sayi1)
                {
                    EnBuyukSayi = sayi3; 
                }
                Console.WriteLine("En Buyuk Sayi: " + EnBuyukSayi);
            }
            Console.ReadLine(); 




        }
    }
}
