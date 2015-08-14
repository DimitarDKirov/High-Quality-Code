using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrics
{
    public interface IConsole
    {
        string ReadLine();

        void WriteLine(string text="");

        void Write(string text="");
    }
}
