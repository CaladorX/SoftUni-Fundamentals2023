﻿namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            FillArray(n, arr);
            PrintMatrix(arr);         
        }

        private static void PrintMatrix(int[] arr)
        {
            for (int i = 0;  i < arr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arr));
            }         
        }

        private static void FillArray(int n, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = n;
            }
        }
    }
}