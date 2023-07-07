using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks.kata_6
{
    internal class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    continue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] % 2 != 0)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
