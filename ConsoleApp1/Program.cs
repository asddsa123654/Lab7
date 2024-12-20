using System;

class Program
{
    static void FindMinMax<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        T max = array[0];

        foreach (var item in array)
        {
            if (item.CompareTo(min) < 0)
                min = item;
            if (item.CompareTo(max) > 0)
                max = item;
        }

        Console.WriteLine($"Min: {min}, Max: {max}");
    }

    static void Main()
    {
        int[] intArray = { 3, 1, 4, 1, 5, 9, 2 };
        FindMinMax(intArray);

        double[] doubleArray = { 3.5, 1.1, 4.8, 1.2, 5.0 };
        FindMinMax(doubleArray);

        Console.ReadKey();
    }
}
