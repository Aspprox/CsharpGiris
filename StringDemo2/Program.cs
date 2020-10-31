using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle: ");
            string cumle = Console.ReadLine();
            //contains içerip içermediğine bakmak için
            while (cumle.Trim() == "")
            {
                Console.Write("Lütfen cümle giriniz: ");
                cumle = Console.ReadLine();
            }

            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();
            while (kelime.Trim() == "")
            {
                Console.WriteLine("Lütfen kelime giriniz: ");
                kelime = Console.ReadLine();
            }
            Console.Write("Büyük küçük harf duyarlı arama? (e: evet, h: hayır)");
            string duyarli = Console.ReadLine();
            while (!(duyarli.ToLower() == "e" || duyarli.ToLower() == "h"))
            {
                Console.Write("Büyük küçük harf duyarlı arama? (e: evet, h: hayır)");
                duyarli = Console.ReadLine();
            }
            KelimeKontrol(cumle, kelime, duyarli);

            Console.ReadLine();

        }

        private static void KelimeKontrol(string cumle, string kelime, string duyarlilik)
        {
            if (duyarlilik == "h")
            {
                cumle = cumle.ToUpper();
                kelime = kelime.ToUpper();

            }
            if (cumle.Contains(kelime))
            {
                Console.WriteLine("Kelime bulundu.");
            }
            else
            {
                Console.WriteLine("Kelime bulunamadı.");
            }
        }
    }
}
