using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortings
{
    internal class HeapSort : Sorting
    {
        public HeapSort(ArrayProvider arrayProvider) : base(arrayProvider)
        {
        }

        public override void Sort(int[] array)
        {
            steps = "";
            iterCount = 0;
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
                heapify(array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                heapify(array, i, 0);
            }
        }

        private void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            if (l < n && arr[l] > arr[largest])
                largest = l;

            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(arr) + "\n\n";
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr, n, largest);
            }
        }

        public override string toString(double milliseconds)
        {
            return $"Сортировка кучей: " + $"Количество итераций: {iterCount}\t" + $"Время: {milliseconds}";
        }
    }
}
