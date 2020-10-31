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
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();    //contains içerip içermediğine bakmak için
            if (cumle.Contains(kelime))
            {
                Console.WriteLine("Kelime bulundu.");
            }
            else
            {
                Console.WriteLine("Kelime bulunamadı.");
            }
            Console.ReadLine();

        }
    }
}
