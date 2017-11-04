namespace SOLID
{
    interface IDatabaseV1 : IDatabase // Gets the Add method
    {
        void Read(); // Added for new clients.
    }
}