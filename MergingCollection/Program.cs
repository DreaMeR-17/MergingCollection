using System;
using System.Collections.Generic;

namespace MergingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int[] array1 = { 2, 4, 9, 11, 21, 7, 18, 5, 50 };
            int[] array2 = { 2, 3, 5, 16, 13, 7, 9, 18, 50 };

            numbers.AddRange(array1);
            numbers.AddRange(array2);

            Console.Write("Коллекция до изменения: ");
            ShowArray(numbers);

            Console.Write($"\nИзмененная коллекция: ");
            MergingCollection(numbers);
            ShowArray(numbers);
        }

        static void ShowArray(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

        static void MergingCollection(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                    }
                    else if (numbers[j] < numbers[i])
                    {
                        numbers.Insert(i, numbers[j]);
                        numbers.RemoveAt(j + 1);
                    }
                }
            }
        }
    }
}
