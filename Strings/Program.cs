using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Fatih";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is burak";

            bool result3 = sentence.EndsWith("h");
            bool result4 = sentence.StartsWith("m");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2);
            Console.WriteLine(result5);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
