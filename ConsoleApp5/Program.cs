using System;

namespace Lecture8.Example1
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            double a = 5.6;
            double b = 8.9;
            Swap<double>(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");

            string str1 = "Hello";
            string str2 = "World";
            Swap<string>(ref str1, ref str2);
            Console.WriteLine($"str1={str1} str2={str2}");

            Console.ReadKey();
        }
    }
}
