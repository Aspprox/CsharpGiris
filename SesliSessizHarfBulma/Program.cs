using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliSessizHarfBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sesliharfler = new string[8];
            sesliharfler[0] = "a";
            sesliharfler[1] = "e";
            sesliharfler[2] = "ı";
            sesliharfler[3] = "i";
            sesliharfler[4] = "o";
            sesliharfler[5] = "ö";
            sesliharfler[6] = "u";
            sesliharfler[7] = "ü";
            Console.WriteLine("Bir kelime giriniz: ");
            string kelime = Console.ReadLine().ToLower();
            while (kelime.Trim() == "")
            {
                Console.WriteLine("Lütfen kelime giriniz: ");
                kelime = Console.ReadLine();
            }
            bool bulundu;
            string sonuc = "";
            foreach (var kelimeKarakter in kelime)
            {
                bulundu = false;
                foreach (var sesliKarakter in sesliharfler)
                {   if (kelimeKarakter.ToString() == sesliKarakter)
                    {
                        bulundu = true;
                        break;
                    }
                }
                if (bulundu)
                {
                    if(!sonuc.Contains(kelimeKarakter))
                    sonuc += kelimeKarakter;
                }
            }
            Console.WriteLine("Kelimenin seslileri: " + sonuc);
            Console.ReadLine();

           
            


        }
        
    }
}
