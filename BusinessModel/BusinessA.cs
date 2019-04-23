using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Lib
{
    public class BusinessA
    {
        IReadNotepad _readNotepad;
        public BusinessA(IReadNotepad readNotepad)
        {
            _readNotepad = readNotepad;
        }

        public void DoRead()
        {
            Console.WriteLine(_readNotepad.Read());
        }

        public async Task DoReadAsync()
        {
            Console.WriteLine(await _readNotepad.ReadAsync());
        }
    }
        
}
