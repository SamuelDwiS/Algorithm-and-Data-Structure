using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace merge_sorting
{
    public class Larik
    {
        public static void merge(int[] depan, int[] belakang, int[] data)
        {
            int index_depan = 0;
            int index_belakang = 0;
            int index_data = 0;

        while(index_depan < depan.Length && index_belakang < belakang.Length)
        {
            if(depan[index_depan] < belakang[index_belakang])
            {
                data[index_data] = depan[index_depan];
                index_depan ++;
            }
            else
            {
                data[index_data] = belakang[index_belakang];
                index_belakang++;
            }
            index_data++;
        }
        System.Array.Copy(depan, index_depan, data, index_data, depan.Length - index_depan);
        System.Array.Copy(belakang, index_belakang, data, index_data, belakang.Length - index_belakang);        
        }

        public static int[] mergeSort(int[] data, int awal, int akhir)
        {
            if(data.Length < 2)
            {
                return data;
            }

            int mid = (awal + akhir) / 2;
            int[]depan = new int[mid];
            int[]belakang = new int[data.Length-depan.Length];

            System.Array.Copy(data, depan, depan.Length);
            System.Array.Copy(data, depan.Length, belakang, 0, belakang.Length);

            mergeSort(depan, 0, mid);
            mergeSort(belakang, mid, belakang.Length);

            merge(depan, belakang, data);
            return data;
        }
    }
}

