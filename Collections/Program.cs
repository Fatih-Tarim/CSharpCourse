using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["table"]);
            foreach (var dic in dictionary)
            {
                Console.WriteLine(dic);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer {Id=1,FirstName="Fatih"});
            //customers.Add(new Customer {Id=2, FirstName="Burak"});

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Fatih" },
                new Customer { Id = 2, FirstName = "Burak" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Çağatay"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] {
                new Customer{Id=4,FirstName="Ali"},
                new Customer{Id=5,FirstName="Ayşe"}
            });
            //contains --> Arama
            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Fatih" })); //false
            Console.WriteLine(customers.Contains(customer2)); //true
            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Last Index: {0}", index2);

            customers.Insert(0, customer2);

            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Fatih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('a');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
