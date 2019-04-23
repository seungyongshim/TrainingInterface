using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public interface IReadAsync
    {
        Task<string> ReadAsync();
    }
}
