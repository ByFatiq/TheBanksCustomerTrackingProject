using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBanksCustomerTrackingProject
{
    class CustomerManager
    {
         public void Add(Customer customer)
        {

            Console.WriteLine("Sayın; "+ customer.FirstName + " "+ customer.LastName+" Bankamıza Hoşgeldiniz.");
            
        }


         public void Delete(Customer customer)
         {

             Console.WriteLine(customer.FirstName + " " + customer.LastName +" Tekrar görüşmek dileğiyle..");

         }

         public void List(Customer[] customers)
         {
             foreach (var customer in customers)
             {
                 Console.WriteLine(customer.FirstName + " " + customer.LastName);
             }
         }
    }
}
