using System;
public class Loop
    {
        public void LoopTask()
        {
            int[] array = new int[100];
            int expectedValue=5;
            bool valueFound= false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    valueFound = true;
                    break;
                }

                Console.WriteLine(array[i]);
            }

            if(valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }

