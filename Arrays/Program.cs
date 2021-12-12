using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Fatih";
            students[1] = "Engin";
            students[2] = "Çağatay";

            string[] students2 = new []{"Engin","Fatih","Çağatay"};
            string[] students3 = { "Engin", "Fatih", "Çağatay" };
            string[] students4 = new string[3] { "Engin", "Fatih", "Çağatay" };


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int r = 0; r <= regions.GetUpperBound(1); r++)
                {
                    Console.WriteLine(regions[i, r]);
                }
                Console.WriteLine("**************");
            }


        }
    }
}
