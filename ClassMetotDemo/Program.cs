using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Selman";
            customer.Surname = "Erdem";
            customer.Mail = "info12@gmail.com";
            customer.PhoneNumber = 555555;

            Customer customer1 = new Customer();
            customer1.Name = "Cemal";
            customer1.Surname = "Kaya";
            customer1.Mail = "info@outlook.com";
            customer1.PhoneNumber = 5555555;

            Customer customer2 = new Customer();
            customer2.Name = "Filiz";
            customer2.Surname = "Akın";
            customer2.Mail = "info22@hotmail.com";
            customer2.PhoneNumber = 555555;


            Customer[] customers = new Customer[] { customer, customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer); // Müşteri Ekleme

            customerManager.Delete(customer1); // Müşteri Silme

            customerManager.List(customers); // Müşterileri Listeleme
            

            
        }
    }
}
