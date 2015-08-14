using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SimpleMaths
{
    class Program
    {
        public static double MeasureAdd<T>(T startvalue, T addition, int count)
        {
            T result;
            Stopwatch sw=Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = (dynamic)startvalue + (dynamic)addition;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;            
        }

        public static double MeasureSubstract<T>(T startvalue, T sub, int count)
        {
            T result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = (dynamic)startvalue - (dynamic)sub;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static double MeasureMultiply<T>(T startvalue, T multi, int count)
        {
            T result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = (dynamic)startvalue * (dynamic)multi;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static double MeasureDivide<T>(T startvalue, T divider, int count)
        {
            T result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = (dynamic)startvalue / (dynamic)divider;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static double MeasureSqrt<T>(T value, int count)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = Math.Sqrt((dynamic)value);
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static double MeasureLogarithm<T>(T value, int count)
        {
            T result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = Math.Log((dynamic)value);
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static double MeasureSinus<T>(T value, int count)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = Math.Sin((dynamic)value);
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
        static void Main(string[] args)
        {
            int count=10000;
            Console.WriteLine("Additions results in miliseconds");
            double intAdd = MeasureAdd<int>(1, 1, count);
            Console.WriteLine("Int: {0}", intAdd);
            double longAdd = MeasureAdd<long>(1, 1, count);
            Console.WriteLine("Long: {0}", longAdd);
            double floatAdd = MeasureAdd<float>(1, 1, count);
            Console.WriteLine("Float: {0}", floatAdd);
            double doubleAdd = MeasureAdd<double>(1, 1, count);
            Console.WriteLine("Double: {0}", doubleAdd);
            double decimalAdd = MeasureAdd<decimal>(1, 1, count);
            Console.WriteLine("Decimal: {0}", decimalAdd);

            Console.WriteLine("Subtract results in miliseconds");
            double intSub = MeasureSubstract<int>(100000, 1, count);
            Console.WriteLine("Int: {0}", intSub);
            double longSub = MeasureSubstract<long>(100000, 1, count);
            Console.WriteLine("Long: {0}", longSub);
            double floatSub = MeasureSubstract<float>(100000, 1, count);
            Console.WriteLine("Float: {0}", floatSub);
            double doubleSub = MeasureSubstract<double>(100000, 1, count);
            Console.WriteLine("Double: {0}", doubleSub);
            double decimalSub = MeasureSubstract<decimal>(100000, 1, count);
            Console.WriteLine("Decimal: {0}", decimalSub);

            Console.WriteLine("Multiplies results in miliseconds");
            double intMultiply = MeasureMultiply<int>(3, 2, count);
            Console.WriteLine("Int: {0}", intMultiply);
            double longMultiply = MeasureMultiply<long>(3, 2, count);
            Console.WriteLine("Long: {0}", longMultiply);
            double floatMultiply = MeasureMultiply<float>(3, 2, count);
            Console.WriteLine("Float: {0}", floatMultiply);
            double doubleMultiply = MeasureMultiply<double>(3, 2, count);
            Console.WriteLine("Double: {0}", doubleMultiply);
            double decimalMultiply = MeasureMultiply<decimal>(3, 2, count);
            Console.WriteLine("Decimal: {0}", decimalMultiply);

            Console.WriteLine("Divide results in miliseconds");
            double intDiv = MeasureDivide<int>(1000000, 2, count);
            Console.WriteLine("Int: {0}", intDiv);
            double longDiv = MeasureDivide<long>(1000000, 2, count);
            Console.WriteLine("Long: {0}", longDiv);
            double floatDiv = MeasureDivide<float>(1000000, 2, count);
            Console.WriteLine("Float: {0}", floatDiv);
            double doubleDiv = MeasureDivide<double>(1000000, 2, count);
            Console.WriteLine("Double: {0}", doubleDiv);
            double decimalDiv = MeasureDivide<decimal>(1000000, 2, count);
            Console.WriteLine("Decimal: {0}", decimalDiv);

            Console.WriteLine("Square root");
            Console.WriteLine("Float: {0}", MeasureSqrt<float>(50,count));
            Console.WriteLine("Double: {0}", MeasureSqrt<double>(50, count));
            Console.WriteLine("Decimal: {0}", MeasureSqrt<decimal>(50, count));

            Console.WriteLine("Natural logarithm");
            Console.WriteLine("Float: {0}", MeasureLogarithm<float>(50, count));
            Console.WriteLine("Double: {0}", MeasureLogarithm<double>(50, count));
            Console.WriteLine("Decimal: {0}", MeasureLogarithm<decimal>(50, count));

            Console.WriteLine("Sinus");
            Console.WriteLine("Float: {0}", MeasureSinus<float>(50, count));
            Console.WriteLine("Double: {0}", MeasureSinus<double>(50, count));
            Console.WriteLine("Decimal: {0}", MeasureSinus<decimal>(50, count));


        }
    }
}
