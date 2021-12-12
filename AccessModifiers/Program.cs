using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Customer
    {
        protected int Id { get; set; }
        public void Save()
        {
            
        }
        public void Delete()
        {

        }
    }
    class Student:Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            
        }

    }
    internal class Course
    {
        public string Name { get; set; }
    }
}
