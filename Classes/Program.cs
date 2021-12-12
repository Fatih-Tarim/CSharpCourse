using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Fatih";
            customer.LastName = "Tarım";
            customer.city = "İstanbul";

            Customer customer2 = new Customer
            {
                Id=2,
                city = "Antalya",
                FirstName="Burak",
                LastName = "Tarım"

            };

            Console.WriteLine(customer2.FirstName);

        }
    }
}
