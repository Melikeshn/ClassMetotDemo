using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FırstName = "Melike";
            customer1.LastName = "Şahin";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FırstName = "Kübra";
            customer2.LastName = "Zağra";


            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = { customer1, customer2 };

            foreach (Customer customer in customers)
            {
                customerManager.Add(customer);
                customerManager.Delete(customer);
                customerManager.Listing(customer);
            }





        }
    }
}