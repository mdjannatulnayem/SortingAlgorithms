
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Algorithms
    {
        private void swap(ref int elem1,ref int elem2)
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

        private int partition(ref int[] arr, int start, int end)
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

        private void conquer(ref int[] arr, int start, int mid, int end)
        {
            int len = end - start + 1;
            int[] merged = new int[len];
            int x = 0, index1 = start, index2 = mid + 1;
            while (index1 <= mid && index2 <= end)
            {
                if (arr[index1] <= arr[index2])
                {
                    merged[x++] = arr[index1++];
                }
                else
                {
                    merged[x++] = arr[index2++];
                }
            }

            while (index1 <= mid)
            {
                merged[x++] = arr[index1++];
            }

            while (index2 <= end)
            {
                merged[x++] = arr[index2++];
            }

            for (int i = 0, j = start; i < len; i++, j++)
            {
                arr[j] = merged[i];
            }

        }

        private void divide(ref int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = start + (end - start) / 2;
            divide(ref arr, start, mid);
            divide(ref arr, mid + 1, end);
            conquer(ref arr, start, mid, end);
        }

        public void mergeSort(ref int[] arr, int start, int end)
        {
            divide(ref arr, start, end);
        }

        public int binarySearch(ref int[] arr, int n, int elem)
        {
            int mid, start = 0, end = n - 1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (elem == arr[mid])
                {
                    return mid;
                }
                else if (elem < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

    }
}
