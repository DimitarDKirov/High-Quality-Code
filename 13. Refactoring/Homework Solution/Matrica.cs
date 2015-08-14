using System;

namespace Matrics
{
    class WalkInMatrica
    {
        static void Main(string[] args)
        {
            IConsole console = new ConsoleWrapper();
            console.WriteLine("Enter a positive number");
            string input = console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                console.WriteLine("You haven't entered a correct positive number");
                input = console.ReadLine();
            }

            MatrixEngine engine = new MatrixEngine(console, n);
            engine.Run();
            engine.PrintMatrix();
        }
    }
}
