using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HQC_HW4_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            OldSize figold = new OldSize(10, 20);
            OldSize figoldrot = OldSize.GetRotatedSize(figold, 3.14);
            Console.WriteLine("old w {0} - h {1}",figoldrot.wIdTh,figoldrot.Viso4ina);
            Size fignew = new Size(10, 20);
            Size fignewrot = Size.GetRotatedSize(fignew, 3.14);
            Console.WriteLine("new w {0} - h {1}", fignewrot.width,fignewrot.height);
            Console.WriteLine("task2");
            StatisticPrinter pr = new StatisticPrinter();
            double[] array={3,2,1,5,-6.12,8,2.3};
            pr.OldPrintStatistics(array, array.Length);
            pr.PrintStatistics(array, array.Length);
        }
    }
}
