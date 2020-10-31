using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sehirler = new string[3, 2] //3:1. boyut index 0, 2: 2. boyut index 1
            {
                { "06", "Ankara"}, //0
                { "34", "İstanbul"}, //1
                { "35", "İzmir"}    //2   //buradaki verilerde turlamak için:
            };
            string sehir;
            for (int r = 0; r <= sehirler.GetUpperBound(0); r++) //r: row(satır)  //(0) satılara göre bakacak
            {
                sehir = "";  //her bir satır için değeri nullıyor
                for (int c = 0; c <= sehirler.GetUpperBound(1); c++) //(1) sütunlara göre bakacak.1 olmasının sebebi indexi
                {
                    sehir = sehir + sehirler[r, c] + " "; //alternatif sehir += sehirler[r, c]
                }
                Console.WriteLine(sehir);
            }
            Console.ReadLine();
        }
    }
}
