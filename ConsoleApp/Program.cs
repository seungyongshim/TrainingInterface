using System;
using System.Threading.Tasks;
using Middleware;
using Middleware.Implements;
using Notepad.Lib;
using Notepad.Lib.Implements;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var consoleRead2 = new ConsoleRead2();
            IReadNotepad readNotepad = new ReadNotepad(consoleRead2, consoleRead2);
            var businessA = new BusinessA(readNotepad);

            businessA.DoRead();
            await businessA.DoReadAsync();
        }
    }
}
