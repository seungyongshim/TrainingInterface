using System;
using System.Threading.Tasks;
using Middleware;

namespace Notepad.Lib
{
    public interface IReadNotepad
    {
        string Read();
        Task<string> ReadAsync();
    }
}
