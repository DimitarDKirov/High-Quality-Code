using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2EvenDifferences
{
    public class EvenDifferences
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long[] inputNumbers = ConvertToNumbers(input);
            long sum = GetEvenDifferencesSum(inputNumbers);
            Console.WriteLine(sum);
        }

        private static long[] ConvertToNumbers(string input)
        {
            string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] inputAsNumbers = Array.ConvertAll<string, long>(splitInput, x => long.Parse(x));
            return inputAsNumbers;
        }

        private static long GetEvenDifferencesSum(long[] numbers)
        {
            long sum = 0;
            long index = 1;
            while (index < numbers.Length)
            {
                long absoluteDifference = Math.Abs(numbers[index] - numbers[index - 1]);

                if (absoluteDifference % 2 == 0)
                {
                    sum += absoluteDifference;
                    index += 2;
                }
                else
                {
                    index += 1;
                }
            }

            return sum;
        }
    }
}
