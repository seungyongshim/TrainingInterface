using System;
using System.Threading.Tasks;
using Middleware;

namespace Notepad.Lib.Implements
{
    public class ReadNotepad : IReadNotepad
    {
        public ReadNotepad(IRead read, IReadAsync readAsync)
        {
            _read = read;
            _readAsync = readAsync;
        }

        IRead _read;
        IReadAsync _readAsync;

        public string Read()
        {
            return _read.Read();
        }

        public async Task<string> ReadAsync()
        {
            return await _readAsync.ReadAsync();
        }
    }
}
