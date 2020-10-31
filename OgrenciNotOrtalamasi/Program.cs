using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. vize: ");
            double vize1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. vize: ");
            double vize2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final: ");
            double final = Convert.ToDouble(Console.ReadLine());
            double Ortalama = (vize1 + vize2) * 20 / 100 + final * 60 / 100;
            if (Ortalama >= 60)
            {
                Console.WriteLine("Ortalama: " + Ortalama + ", Geçtiniz.");
            }
            else 
            {
                Console.WriteLine("Ortalama: " + Ortalama + ", Kaldınız.");
            }
            //Console.WriteLine((vize1 + vize2) * 20 / 100 + final * 60 / 100); test için
            Console.ReadLine();

            
        }
    }
}
