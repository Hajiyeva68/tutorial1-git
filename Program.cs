static int CalculateMin(int[] values)
{
    int min = values[0];

    foreach (int v in values)
    {
        if (v < min)
            min = v;
    }

    return min;
}