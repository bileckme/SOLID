using System;
using SOLID.OCP;

namespace SOLID.LSP
{
    class MyException : Exception
    {
        public void Handle(string message)
        {
            //System.Console.WriteLine(message);
        }
    }
    
    class CustomerLSP : CustomerOCP, IDiscount, IDatabase
    {
        private MyException obj = new MyException();
        
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.Message.ToString());
            }
        }
    }
    
    class Enquiry : CustomerOCP, IDiscount
    {
        public  double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
