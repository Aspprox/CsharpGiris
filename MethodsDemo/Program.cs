using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize1 = KullanıcıdanGirisAl("1. vize");
            double vize2 = KullanıcıdanGirisAl("2. vize");
            double final = KullanıcıdanGirisAl("Final");
            double ortalama = OrtalamaHesapla(vize1, vize2, final);
            GeçmeKalmaGöster(ortalama);
            //GeçmeKalmaGöster(ortalama, 70);

            Console.ReadLine();
        }

        private static void GeçmeKalmaGöster(double ortalama, double geçmeNotu = 60)
        {
            if (ortalama >= geçmeNotu)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }

            Console.ReadLine();
        }

        private static double OrtalamaHesapla(double vize1, double vize2, double final)
        {
            double sonuc = (vize1 + vize2) * 0.2 + final * 0.6;
            return sonuc;
        }

        static double KullanıcıdanGirisAl(string hangiSinav) //fiil olarak isimlendir.
        {
            Console.WriteLine(hangiSinav + ": ");
            return Convert.ToDouble(Console.ReadLine());

        }

    }
}
