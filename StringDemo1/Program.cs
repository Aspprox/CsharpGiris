using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime giriniz: ");
            string kelime = Console.ReadLine();
            string tersKelime = Reverse(kelime);
            Console.WriteLine("Kelimenin tersi: " + tersKelime);
            Console.ReadLine(); 
                
           
        }

        static string Reverse(string input)
        {
            string output = "";
            for (int i = input.Lenght - 1; i >=0 ; i--)
            {
                output = output + input[i];  //output += input[i]
            }
            return output;
        }
    }
}
