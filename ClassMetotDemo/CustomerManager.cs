using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congratulations new customer Added. : " + customer.Name + " " + customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Congratulations customer deleted. : " + customer.Name + " " + customer.Surname);
        }

        public void List(Customer[] customer)
        {
            foreach (var list in customer)
            {
                Console.WriteLine(list.Name + " " + list.Surname + " :\n " + list.Mail + " \n " + list.PhoneNumber);
            }
        }
    }
}
