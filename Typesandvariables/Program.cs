using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Typesandvariables
{
    class Program
    {
        static void Main(string[] args)

     

        {
            //1 byte = 8 bits region yazacağımız kodları gruplamak için
            #region Value Types 
            #region Integer 
            int number1 = 10; //32 bitlik(int) - 2 billion ile +2 billion arasındaki sayıları tutması mümkün(yaklaşık)
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("int min: {0}, int max: {1}", int.MinValue, int.MaxValue);
            uint number2 = 1;/* u: unsigned int daki - li kısmı + lı kısma ekler ve sadece pozitif olan tutar*/




            #endregion

            #region Long 
            long number3 = 2147483648; // 64 bitlik. yaklaşık -9 +9 quintillion arasındaki tamsayı verilerini tutar.yani Long int i kapsar
            ulong number4 = 40; //0 dan başlar 18 quintillion a kadar veri tutar.
            #endregion


            #region
            short number5 = -89; //16 bitlik -32768 + 32767
            ushort number6 = 6; // 0 ile 65535 arası 
            #endregion

            #region
            byte number7 = 255; // 8 bitlik alan tutar. 0-255
            sbyte number8 = -64; // -128 ile 217 arasını tutabilir.
            #endregion


            #region Boolean
            bool condition = true; // 1, false: 0.   c# da 1 bit olarak değil 1 byte tutuyor.ya küçük true ya da küçük false yazılır 
            Console.WriteLine(condition);
            #endregion


            #region Char 
            char character = 'A'; // metinsel olanlar tek tırnakla tutulur.ASCII kullanıyorsa 8 bitlik alan kullanır
            //Unicode kullanıyorsa 16 bit
            Console.WriteLine("Character: " + character + ",ASCII code: " + (int)character); //int e dönüştürmek istediğimiz için int yazdık.
                                                                                             //veri dönüşümü yapmanın bir yolu
            #endregion


            #region Double 
            double number9 = 10.7; // ondalık sayıları tutar ama 10 da yazabilirsin yanına .0 yazar öyle tutar.64 bit.
            Console.WriteLine(number9); //c# da nokta ile tanımlarız ondalıkları //sql deki floatın karşılığı //- kullanabilirsin.
            #endregion

            #region float 
            float number10 = 12.34567f; //float olduğunu algılayabilmesi için sayının sonuna f ya da F yazmalısın.32 bit 
            Console.WriteLine(number10); // bu tarz işler için double kullanman daha mantıklı.
            #endregion

            #region Decimal
            decimal number11 = 12.3456789m; // 24 * 8 bits 28-29 significant digits doubledan da fazla yer kaplıyor.sonuana m ya da M koymalısın.
            Console.WriteLine(number11);
            #endregion



            #region Enum
            //string gun = "Pazartesi";
            //int gunSayi = 1; // 1: Pazartesi 2:Salı 
            // enum metodların dışında tanımlanır. Karışıklıkları önler.
            Console.WriteLine(Gunler.Cumartesi + " " + (int)Gunler.Cumartesi); // ben bunu ilk başta + sız yazdırırsam cumartesi yazar ama 
                                                                               //bu günün sayısal değerini merak edersem int ile dönüşüm yapmam lazım.
            #endregion

            #endregion


            #region Reference Types 
            string characters = "Çağıl"; // 4 byte address.karakter dizisi = string. en fazla 2 milyar byte
            Console.WriteLine("İsim = " + characters);
            #endregion

            #region Var
            var number123 = 19; // veritipi belirtmeden tanımladığın veriye göre veri tipi tutan bri yapı.
            Console.WriteLine(number123);
            #endregion



            Console.ReadLine();
        }

        enum Gunler
        { 
            Pazartesi = 1, //kendi zaten 0 değerini atamıştı.Biz burada 1 yaotık
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        
        }

    }
}