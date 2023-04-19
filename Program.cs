using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GrokkingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 6, 7, 9, 10, 12, 15, 16, 19, 20, 26 };
            Console.WriteLine(BinarySearch(arr, 7));
            Console.WriteLine(BinarySearch(arr, 16));
        }

        static int BinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (item == arr[mid])
                    return mid + 1;
                int guess = arr[mid];
                if (guess < item)
                    low = mid + 1;
                else
                {
                    high = mid - 1; 
                }
            }
            return -1;
        }
    }
}