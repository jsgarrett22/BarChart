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
                    Console.WriteLine($"{"     100: "}{CalculateBars(array[i])}");
                } else if (i == 9)
                {
                    Console.WriteLine($"{"   90-99: "}{CalculateBars(array[i])}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"{"   80-89: "}{CalculateBars(array[i])}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"{"   70-79: "}{CalculateBars(array[i])}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"{"   60-69: "}{CalculateBars(array[i])}");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"{"   50-59: "}{CalculateBars(array[i])}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"{"   40-49: "}{CalculateBars(array[i])}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"{"   30-39: "}{CalculateBars(array[i])}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{"   20-29: "}{CalculateBars(array[i])}");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{"   10-19: "}{CalculateBars(array[i])}");
                }
                else if (i == 0)
                {
                    Console.WriteLine($"{"   0-9: "}{CalculateBars(array[i])}");
                } else
                {
                    Console.WriteLine("Invalid range.");
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
