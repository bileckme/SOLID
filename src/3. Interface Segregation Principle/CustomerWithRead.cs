namespace SOLID
{
    public class CustomerWithRead: CustomerISP, IDatabase, IDatabaseV1
    {
        public void Read()
        {
            // Implements  logic for read
            throw new System.NotImplementedException();
        }
    }
}