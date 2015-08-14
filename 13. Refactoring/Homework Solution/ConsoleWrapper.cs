using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrics
{
    class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
            return;
        }
        public void Write(string text)
        {
            Console.Write(text);
            return;
        }
    }
}
