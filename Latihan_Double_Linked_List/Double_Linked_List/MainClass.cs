using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList my_list = new LinkedList();
            my_list.addFirst(15);
            my_list.addLast(20);
            my_list.addFirst(5);
            my_list.addLast(2);
            my_list.addFirst(60);

            Console.WriteLine("Size : " + my_list.getSize());
            Console.WriteLine("List awal : " + my_list.ToString());

            // Console.WriteLine("removeFirst() : " + my_list.removeFirst().getData());
            // Console.WriteLine("removeLast() : " + my_list.removeLast().getData());
            // Console.WriteLine("List setelah remove " + my_list.ToString());


            /*Operasi Lanjutan*/

            int data = 15;
            Boolean delete = my_list.select_remove(data);
            if (delete)
            {
                Console.WriteLine("Node dengan data : " + data + " berhasil dihapus");
                Console.WriteLine("Isi list  : " + my_list.ToString() + " berhasil dihiapus");

            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
            }

            Console.WriteLine("Data index 0 : " + my_list.indexof(0));
            Console.WriteLine("Data index 1 : " + my_list.indexof(1));
            Console.WriteLine("Data index 2 : " + my_list.indexof(2));
            Console.WriteLine("Data index 3 : " + my_list.indexof(3));

            my_list.update_element(3,33);
            Console.WriteLine("Mengubah data index ke-3 : " + my_list.ToString());

            my_list.add_by_index(3,404);
            Console.WriteLine("Menambahkan data index ke-3 : " + my_list.ToString());

             Console.WriteLine("Data index 3 : " + my_list.indexof(3));
        }
    }
}