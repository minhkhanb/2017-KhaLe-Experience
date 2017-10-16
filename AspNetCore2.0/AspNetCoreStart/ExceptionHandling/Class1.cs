using System;

namespace ExceptionHandling
{
    public interface IException
    {
        string Handle();
    }
    public class EventExceptionHandler : IException
    {
        public string Handle()
        {
            return "Event viewer";
        }
    }
    public class FileExceptionHandler : IException
    {
        public string Handle()
        {
            return "File";
        }
    }
}
