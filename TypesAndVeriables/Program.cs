using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");

            //Value Types
            
            decimal number6 = 10.4m; // decimal değerlerde ondalık sayı tutulursa sonuna 'm' harfi gelir
            double number5 = 10.7; // 64 bitlik yer tutar
            char character = 'A';
            bool condition = true;
            byte number4 = 0; // 0 ile 255 arasında sayı tutar
            short number3 = -32768; // 16 bit yer kaplar
            int number1 = 2147483647; //32 bit yer kaplar
            long number2 = -9223372036854775808; //64 bit yer kaplar
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}",character); // karakterin ascii kodunu görmek için bir alt satırı kullan
            Console.WriteLine("Ascii code is : {0}",(int) character);
            Console.WriteLine((int)Days.Friday); // Sırasını ekrana yazdırır - 0 dan başlayarak
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
