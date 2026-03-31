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

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
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
}