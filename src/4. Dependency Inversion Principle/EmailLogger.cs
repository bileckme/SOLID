namespace SOLID.DIP
{
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
            throw new System.NotImplementedException();
        }
    }
}