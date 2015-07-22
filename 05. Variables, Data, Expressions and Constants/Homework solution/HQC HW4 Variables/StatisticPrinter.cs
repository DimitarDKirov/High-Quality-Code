public class StatisticPrinter
{
    public void PrintStatistics(double[] inputData, int numberOfElements)
    {
        double maxValue = inputData[0];
        for (int i = 1; i < numberOfElements; i++)
        {
            if (inputData[i] > maxValue)
            {
                maxValue = inputData[i];
            }
        }

        PrintMax(maxValue);

        double minValue = inputData[0];
        for (int i = 1; i < numberOfElements; i++)
        {
            if (inputData[i] < minValue)
            {
                minValue = inputData[i];
            }
        }

        PrintMin(minValue);

        double sum = 0;
        for (int i = 0; i < numberOfElements; i++)
        {
            sum += inputData[i];
        }

        double average = sum / numberOfElements;
        PrintAvg(average);
    }
}

