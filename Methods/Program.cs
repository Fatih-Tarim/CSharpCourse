using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(23);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,5));

            Console.WriteLine(Add4(2, 6, 9, 7, 8));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2=4)
        {

            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
