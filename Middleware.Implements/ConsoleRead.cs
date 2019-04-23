using System;

namespace Middleware.Implements
{
    public class ConsoleRead : IRead
    {
        public ConsoleRead()
        {
        }

        public string Read()
        {
            return "ConsoleRead";
        }
    }
}
