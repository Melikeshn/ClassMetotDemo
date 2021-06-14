using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla eklendi.  "+ customer.FırstName +" "+ customer.LastName);

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla silindi.  "+ customer.FırstName + " " + customer.LastName);
        }
        public void Listing(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla listelendi.  "+ customer.FırstName +" "+ customer.LastName);
        }

    }
}
