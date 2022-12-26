// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

namespace ConsoleFinalWork
{
    class Program
    {
        static void Sort(string[] arr1, string[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].Length <= 3)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
        }
        static void Main(string[] args)
        {
            string[] arr1 = new string[4] { "hello", "2", "world", ":-)" };
            string[] arr2 = new string[arr1.Length];
            Sort(arr1, arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            Console.WriteLine();
        }
    }
}