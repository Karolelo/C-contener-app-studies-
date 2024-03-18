using System;

namespace ConsoleApplication2
{
    public class OverFillException : Exception
    {
        public  OverFillException()
        {
        }

        public OverFillException(string message) : base(message)
        {
        }

        public OverFillException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}