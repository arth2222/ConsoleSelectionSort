using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 2, 1, 6, 9, 12, 13, 8, 5 };
            //SelectionSort();
            arr=sortFromBehind(arr);

            foreach(int tall in arr)
                Console.WriteLine(tall);

            Console.ReadLine();
        }

        //static int[] ArthurSort()
        //{
        //    int[] arr = { 4, 7, 2, 1, 6, 9, 12, 13, 8, 5 };
            
        //    int min=arr.Min();

        //}

        static int[] SelectionSort()//martin
        {
            int[] arr = { 4, 7, 2, 1, 6, 9, 12, 13, 8, 5 };
            int min;
            int index = 0;
            bool swap;

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                min = arr[i];
                swap = false;
                for (int j = i; j < arr.Length - 1; j++)//nb, se at j blir lik i. Her elimineres en og en plass i arrayen.
                {
                    if (min > arr[j + 1])
                    {
                        min = arr[j + 1];
                        index = j + 1;
                        swap = true;
                    }
                }
                if (swap)
                {
                    arr[index] = arr[i];
                    arr[i] = min;
                }
            }
            return arr;
        }

        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        //1. find highest
        //2. putt den bakerst
        static int[] sortFromBehind(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = n-1; i > 0; i--)
            {
                // Find the minimum element in unsorted array 
                int max_idx = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[max_idx])
                        max_idx = j;
                }

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[max_idx];
                arr[max_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
