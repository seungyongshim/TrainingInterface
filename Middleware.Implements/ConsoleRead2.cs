using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Implements
{
    public class ConsoleRead2 : ConsoleRead, IReadAsync
    {
        public async Task<string> ReadAsync()        {
            return await Task.Factory.StartNew(() => "ConsoleRead2");
        }
    }
}
