
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Algorithms
    {
        public void swap(ref int elem1,ref int elem2)
        {
            int t = elem1;
            elem1 = elem2;
            elem2 = t;
        }

        public void bubbleSort(ref int[] arr, int n)
        {
            bool isSorted;
            for (int i = 0; i < n; i++)
            {
                isSorted = true;
                for (int j = 1; j < n - i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        swap(ref arr[j],ref arr[j - 1]);
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    break;
                }
            }
        }

        public void selectionSort(ref int[] arr, int n)
        {
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                swap(ref arr[min],ref arr[i]);
            }
        }

        public void insertionSort(ref int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = current;
            }
        }

        public int partition(ref int[] arr, int start, int end)
        {
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (arr[j] < arr[end])
                {
                    i++;
                    swap(ref arr[i],ref arr[j]);
                }
            }
            i++;
            swap(ref arr[i],ref arr[end]);
            return i;
            //returning pivot index!
        }

        public void quickSort(ref int[] arr, int start, int end)
        {
            int pivot;
            if (start < end)
            {
                pivot = partition(ref arr, start, end);
                //recursive calls after partition!
                quickSort(ref arr, pivot + 1, end);
                quickSort(ref arr, start, pivot - 1);
            }
        }

    }
}
