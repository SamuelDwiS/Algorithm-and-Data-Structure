using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asc_sorting
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sorting Bilangan");
            int[] bilangan = { 15, 8, 26, 5, 11, 31 };
            Asc_sorting.setData(bilangan);
            Asc_sorting.print();

            Console.WriteLine("Bubble Sorting");
            int[] bubble = Asc_sorting.bubble_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(bubble[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Insertion Sort");
            int[] insertion = Asc_sorting.insertion_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(insertion[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Selection Sort");
            int[] selection = Asc_sorting.selection_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(selection[i] + " ");


            }
            Console.WriteLine(" ");


            Console.WriteLine("\nBubble Sort Descend");
            int[] desc_bubble = Desc_sorting.bubble_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(desc_bubble[i] + " ");


            }
            Console.WriteLine(" ");

            Console.WriteLine("Insertion Sort Descend");
            int[] desc_insertion = Desc_sorting.insertion_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(desc_insertion[i] + " ");


            }
            Console.WriteLine(" ");

            Console.WriteLine("Selection Sort Descend");
            int[] desc_selection = Desc_sorting.insertion_sort(bilangan);
            for (int i = 0; i < bilangan.Length; i++)
            {
                Console.Write(desc_selection[i] + " ");
            }
            Console.WriteLine(" ");



        }
    }
}