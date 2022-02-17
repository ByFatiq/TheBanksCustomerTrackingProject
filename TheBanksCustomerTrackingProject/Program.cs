using System;

namespace TheBanksCustomerTrackingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.FirstName = "Fatih";
            customer1.LastName = "C.";
            customer1.Gender = "E";
            customer1.IdentityNumber = "123456";
            customer1.Age = 26;

            Customer customer2 = new Customer();

            customer2.Id = 1;
            customer2.FirstName = "Fatih";
            customer2.LastName = "Ceker";
            customer2.Gender = "E";
            customer2.IdentityNumber = "123456";
            customer2.Age = 26;

            Customer[] customers = new Customer[]{ customer1, customer2 };
            CustomerManager cm = new CustomerManager();

            cm.Add(customer1);
            cm.Add(customer2);


            Console.WriteLine(" <====Müşteriler Eklendi.======>\n\n");


            cm.List(customers);

            Console.WriteLine(" <====Müşteriler Listelendi.======>\n\n");






            cm.Delete(customer1);
            cm.Delete(customer2);


            Console.WriteLine(" <====Müşteriler Silindi.======>");





           

         
        }
    }
}
