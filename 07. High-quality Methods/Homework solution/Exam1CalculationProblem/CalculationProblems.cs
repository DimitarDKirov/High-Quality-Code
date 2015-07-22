using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1CalculationProblem
{
    class CalculationProblems
    {
        private const int SystemBase = 23;
        private const int NumberOfLetters = 10;

        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int sumInDecimal = SumOfWordsSums(inputData);
            string codedText = CodeNumbertoText(sumInDecimal, SystemBase);
            Console.WriteLine(codedText);
        }

        private static int SumOfWordsSums(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int allWordsSum = 0;
            foreach (string word in words)
            {
                int wordSum = ConvertStringToDecimal(word);
                allWordsSum += wordSum;
            }

            return allWordsSum;
        }

        private static int ConvertStringToDecimal(string word)
        {
            int lettersSum = 0;
            int letterWeight = 1;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                int letterNumber = word[i] - 'a';
                int letterValue = letterWeight * letterNumber;
                lettersSum += letterValue;
                letterWeight *= SystemBase;
            }

            return lettersSum;
        }

        private static string CodeNumbertoText(int sumInDecimal, int SystemBase)
        {
            char[] codedNumber = new char[NumberOfLetters];
            int letterPosition = 0;
            int divideRemainder = sumInDecimal;
            do
            {
                int letterNumber = divideRemainder % SystemBase;
                char letter = Convert.ToChar(letterNumber + 'a');
                codedNumber[letterPosition] = letter;
                divideRemainder /= SystemBase;
                letterPosition += 1;
            } while (divideRemainder > 0);

            Array.Reverse(codedNumber);
            string result = new string(codedNumber, codedNumber.Length - letterPosition, letterPosition);
            return result.Trim();
        }
    }
}
