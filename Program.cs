using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        double average = CalculateAverage(numbers);
        int min = FindMin(numbers);
        int max = FindMax(numbers);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }

    static double CalculateAverage(int[] values)
    {
        int sum = 0;

        foreach (int v in values)
        {
            sum += v;
        }

        return (double)sum / values.Length;
    }

    static int FindMin(int[] values)
    {
        int min = values[0];

        foreach (int v in values)
        {
            if (v < min)
                min = v;
        }

        return min;
    }

    static int FindMax(int[] values)
    {
        int max = values[0];

        foreach (int v in values)
        {
            if (v > max)
                max = v;
        }

        return max;
    }
}