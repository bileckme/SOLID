using SOLID.LSP;

namespace SOLID.ISP
{
    public class CustomerISP : CustomerLSP
    {
        public void Add()
        {
            Customer obj = new Customer();
            obj.Add();
        }
    }
}