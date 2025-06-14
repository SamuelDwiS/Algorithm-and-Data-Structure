using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quick_sorting
{
    public class Larik
    {
        public static void quickSort(int[] data, int low, int high)
        {
            int i = low, j = high, temp;
            int pivot = data[(low + high) / 2];
            do
            {
                // i bergerak dari kiri ke kanan
                while (data[i] < pivot)
                {
                    i++;
                }

                // j bergerak dari kanan ke kiri
                while (data[j] > pivot)
                {
                    j--;
                }

                // tukar data[i] dengan data[j]
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }
            while (i < j);

            if (low < j)
            {
                // lakukan quicksort untuk sub array kanan
                quickSort(data, low, j);
            }

            if (i < high)
            {

                // lakukan quicksort untuk sub array kiri
                quickSort(data, i, high);
            }

        }
    }
}
