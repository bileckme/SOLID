namespace SOLID.SRP
{
    class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"./resources/Error.txt", error);
        }
    }
}

