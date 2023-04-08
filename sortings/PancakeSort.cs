using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortings
{
    internal class PancakeSort : Sorting
    {
        public PancakeSort(ArrayProvider arrayProvider) : base(arrayProvider)
        {
        }

        public override void Sort(int[] array)
        {
            steps = "";
            iterCount = 0;
            int n = array.Length;
                
            for (int i = n - 1; i > 0; i--)
            {
                int maxIndex = FindMaxIndex(array, i);

                if (maxIndex != i)
                {
                    Flip(array, maxIndex);
                    steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
                    Flip(array, i);
                    steps += iterCount++ + ": " + arrayProvider.ArrayToString(array) + "\n\n";
                }
            }
        }

        public override string toString(double milliseconds)
        {
            return $"Сортировка pancake: " + $"Количество итераций: {iterCount}\t" + $"Время: {milliseconds}";
        }

        private int FindMaxIndex(int[] arr, int n)
        {
            int maxIndex = 0;

            for (int i = 0; i <= n; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void Flip(int[] arr, int n)
        {
            int i = 0;
            int j = n;

            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
        }
    }
}
