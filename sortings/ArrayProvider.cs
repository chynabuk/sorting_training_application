using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortings
{
    partial class ArrayProvider
    {
        private Random random;

        public ArrayProvider()
        {
            random = new Random();
        }

        public int[] GenerateArray(int size)
        {
            int[] array;
            if (size == 0)
            {
                array = new int[0];
            }
            else
            {
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = GenerateNumber();
                }
            }

            return array;
        }

        private int GenerateNumber()
        {
            return random.Next(-100, 100);
        }

        public string ArrayToString(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return "массив пустой";
            }
            string strArray = "[";
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1) strArray += array[i] + "]";
                else strArray += array[i] + ", ";
            }
            return strArray;
        }
    }
}
