using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BST;

namespace BST
{
    public class MainClass
    {
        public static void Main(string[]args)
        {
        TreeList my_tree = new TreeList();

        my_tree.add_data(23);
        my_tree.add_data(19);
        my_tree.add_data(5);
        my_tree.add_data(45);
        my_tree.add_data(35);
        my_tree.add_data(65);
        my_tree.add_data(33);
        my_tree.add_data(42);

        Console.WriteLine("Masukkan Angka: ");
        int angka = int.Parse(Console.ReadLine());

        int search_test = my_tree.search(angka);
        if(search_test == angka)
        {
            Console.WriteLine("Data Ditemukan");
        } 
        else 
        {
            Console.WriteLine("Data Tidak Ditemukan");
        }

    }

    }
}