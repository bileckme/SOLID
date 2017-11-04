using System.Collections.Generic;
using SOLID.LSP;
using SOLID.OCP;

namespace SOLID.DIP
{
    public class Program {

        public static void Main (string[] args) 
        {
            List<CustomerOCP> Customers = new List<CustomerOCP>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer()); // Using OCP
            Customers.Add(new Enquiry()); // Using ISP

            foreach (CustomerLSP o in Customers)
            {
                o.Add();
            }
        
            IDatabase i = new CustomerLSP(); // 1000 happy old clients not touched
            i.Add(); // using Liskov

            IDatabaseV1 iv1 = new CustomerWithRead(); // new clients
            iv1.Read();
        }
    }
}

