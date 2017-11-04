namespace SOLID.DIP
{
    public class EventViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
            throw new System.NotImplementedException();
        }
    }
}