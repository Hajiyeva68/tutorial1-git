 static void Main()
{
    int[] numbers = { 10, 20, 30, 40, 50 };

    int sum = 0;

    foreach (int n in numbers)
    {
        sum += n;
    }

    double average = CalculateAverage(numbers);
    int min = CalculateMin(numbers);
    int max = FindMax(numbers);

    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Min: " + min);
    Console.WriteLine("Max: " + max);
}