using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplaceQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 8, 1, 6, 2, 5, 1, 3, 10, 0, 15, 5 };

            Console.WriteLine("Array before sorting:");
            foreach (var t in input)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("");


            Console.WriteLine("Array after sorting:");
            Stopwatch stopwatch = Stopwatch.StartNew();
            QuickSort(input,0,input.Length-1);
            stopwatch.Stop();
            foreach (var t in input)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("Execution Time: {0}", stopwatch.ElapsedMilliseconds);
            Console.Read();

        }

        public static void QuickSort(int[] nos, int left, int right)
        {
            if (left >= right)
                return;

            int pivotIndex = Partition(nos, left, right);
            QuickSort(nos, left, pivotIndex - 1);
            QuickSort(nos, pivotIndex+1, right);
        }

        public static int Partition(int[] arr, int left ,int right)
        {
            int start = left;
            int pivot = arr[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && arr[left] <= pivot)
                    left++;

                while (left <= right && arr[right] > pivot)
                    right--;

                if (left > right)
                {
                    arr[start] = arr[left - 1];
                    arr[left - 1] = pivot;

                    return left;
                }


                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

            }
        }

        private static void Swap(int[] array, int left, int right)
        {
            int tmp = array[right];
            array[right] = array[left];
            array[left] = tmp;
        }
        
    }
}
