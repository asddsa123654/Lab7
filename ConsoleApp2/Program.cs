using System;

class MinMaxFinder<T> where T : IComparable<T>
{
    public T FindMin(T a, T b)
    {
        return a.CompareTo(b) < 0 ? a : b;
    }
}

class Program
{
    static void Main()
    {
        MinMaxFinder<int> intFinder = new MinMaxFinder<int>();
        Console.WriteLine($"Min of 10 and 20: {intFinder.FindMin(10, 20)}");

        MinMaxFinder<double> doubleFinder = new MinMaxFinder<double>();
        Console.WriteLine($"Min of 10.5 and 20.3: {doubleFinder.FindMin(10.5, 20.3)}");

        Console.ReadKey();
    }
}
