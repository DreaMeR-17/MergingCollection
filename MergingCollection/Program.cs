using System;
using System.Collections.Generic;

namespace MergingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 4, 9, 11, 21, 7, 18, 5, 50 };
            int[] array2 = { 2, 3, 5, 16, 13, 7, 9, 18, 50 };

            Console.Write("Первый массив: ");
            ShowArray(array1);

            Console.Write("Второй массив: ");
            ShowArray(array2);

            List<int> numbers = new List<int>();

            MergingCollection(numbers, array1);
            MergingCollection(numbers, array2);

            Console.Write("\nМассивы после объединения: ");
            ShowList(numbers);
        }

        static void MergingCollection(List<int> numbers, int[] array)
        {
            foreach (var value in array)
            {
                if (numbers.Contains(value) == false)
                {
                    numbers.Add(value);
                }
            }
        }

        static void ShowList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine(numbers[numbers.Count - 1]);
        }

        static void ShowArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
