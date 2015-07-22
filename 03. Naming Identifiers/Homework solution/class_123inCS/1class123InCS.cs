//Task 1. class_123 in C#
using System;

namespace HomeworkNaming
{
    class Printer
    {
        const int maxCount = 6;
        class ConsolePrinter
        {
            public void Print(bool valueToPrint)
            {
                string convertedValueToPrint = valueToPrint.ToString();
                Console.WriteLine(convertedValueToPrint);
            }
        }

        public static void Initialize()
        {
            Printer.ConsolePrinter printer = new Printer.ConsolePrinter();
            printer.Print(true);
        }
    }
}