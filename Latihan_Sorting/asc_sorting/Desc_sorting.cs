using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asc_sorting
{
    public class Desc_sorting
    {
        private static int[] data;
        public static int[] getData()
        {
            return Desc_sorting.data;

        }

        public static void setData(int[] data)
        {
            Desc_sorting.data = data;
        }

        public static int[] bubble_sort(int[] data)
        {
            for (int i = 1; i <= data.Length - 1; i++)
            {
                for (int j = 0; j <= data.Length - 1 - i; j++)
                {
                    if (data[j] < data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }

        public static int[] insertion_sort(int[] data)
        {
            for (int i = 1; i <= data.Length - 1; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (data[j] > data[j - 1])
                    {
                        int temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                }
            }
            return data;
        }

        public static int[] selection_sort(int[] data)
        {
            int minIndex;
            for (int i = 0; i <= data.Length - 2; i++)
            {
                minIndex = i;
                for (int j = i + 1; j <= data.Length - 1; j++) // mencari nilai maks atau mins
                {
                    if (data[j] > data[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = data[minIndex];
                data[minIndex] = data[i];
                data[i] = temp;
            }
            return data;
        }



    }
}