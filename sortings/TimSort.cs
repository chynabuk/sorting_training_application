using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortings
{
    internal class TimSort : Sorting
    {
        private const int MIN_MERGE = 32;

        public TimSort(ArrayProvider arrayProvider) : base(arrayProvider)
        {
        }

        public override void Sort(int[] array)
        {
            steps = "";
            iterCount = 0;
            int n = array.Length;
            if (n < 2)
            {
                return;
            }

            int minRun = CalculateMinRun(n);

            for (int i = 0; i < n; i += minRun)
            {
                InsertionSort(array, i, Math.Min(i + minRun - 1, n - 1));
            }

            for (int size = minRun; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min(left + 2 * size - 1, n - 1);

                    
                    if (mid < right)
                    {
                        Merge(array, left, mid, right);
                    }
                }
            }
        }
        private int CalculateMinRun(int n)
        {
            int r = 0;

            while (n >= MIN_MERGE)
            {
                r |= (n & 1);
                n >>= 1;
            }

            return n + r;
        }

        private void InsertionSort(int[] array, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= left && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                    steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
                }

                array[j + 1] = key;
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int len1 = mid - left + 1;
            int len2 = right - mid;
            int[] leftArray = new int[len1];
            int[] rightArray = new int[len2];

            int i, j, k;
            for (i = 0; i < len1; i++)
            {
                leftArray[i] = array[left + i];
            }

            for (i = 0; i < len2; i++)
            {
                rightArray[i] = array[mid + 1 + i];
            }

            k = left;
            j = 0;
            i = 0;

            while (i < len1 && j < len2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }

                k++;
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
            }

            while (i < len1)
            {
                array[k] = leftArray[i];
                k++;
                i++;
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
            }

            while (j < len2)
            {
                array[k] = rightArray[j];
                k++;
                j++;
                steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
            }
        }

        public override string toString(double milliseconds)
        {
            return $"Сортировка Тима: " + $"Количество итераций: {iterCount}\t" + $"Время: {milliseconds}";
        }
    }
}
