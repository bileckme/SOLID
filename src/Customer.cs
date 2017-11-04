using System;

namespace SOLID
{
    class Customer
    {
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"./resources/Error.txt", ex.ToString());
            }
        }
    }
}
