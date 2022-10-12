using System;

namespace BarChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Grade Distribution");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine($"{"  100: "}{CalculateBars(array[i])}");
                } else
                {
                    Console.WriteLine($"{i * 10:D2}-{i * 10 + 9:D2}: {CalculateBars(array[i])}");
                }
            }
        }
        public static string CalculateBars(int numOfGrades)
        {
            string bar = "*";

            if (numOfGrades != 0)
            {
                for (int i = 1; i < numOfGrades; i++)
                {
                    bar += "*";
                }
                return bar;
            } else
            {
                return "";
            }
        }
    }
}
