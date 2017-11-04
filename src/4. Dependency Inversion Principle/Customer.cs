using System;
using SOLID.ISP;
using SOLID.LSP;

namespace SOLID.DIP
{
    interface IException
    {
        void Handle(string error);
    }
    
    public class Customer : CustomerISP, IDiscount, IDatabase
    {
        private ILogger obj;
        public Customer(ILogger i)
        {
            obj = i;
        }
    }
}