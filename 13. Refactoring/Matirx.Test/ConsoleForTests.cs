using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrics;

namespace MatirxTest
{
    class ConsoleForTests : IConsole
    {
        private string textToRead;
        private string textToWrite;

        public ConsoleForTests()
        {
            this.textToRead = "";
            this.textToWrite = "";
        }

        public string ReadLine()
        {
            return this.textToRead;
        }

        public void WriteLine(string text = "")
        {
            if (text.IndexOf("Enter a positive number") >= 0)
            {
                return;
            }

            this.textToWrite += text + '\n';
        }

        public void Write(string text = "")
        {
            this.textToWrite += text;
        }

        public void SetReadText(string read)
        {
            this.textToRead = read;
        }

        public string GetWriteText()
        {
            string result = this.textToWrite;
            this.textToWrite = "";
            return result.TrimEnd();
        }
    }
}
