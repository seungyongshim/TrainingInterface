using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Implements
{
    public class ConsoleRead3 : IRead, IReadAsync
    {
        public ConsoleRead3()
        {
        }

        public Task<string> ReadAsync()
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }
    }
}
