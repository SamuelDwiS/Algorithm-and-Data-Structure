using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BST;

namespace BST_Delete
{
    public class MainClass_Delete
    {
        public static void Main(string[] args)
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

            Console.WriteLine("Pre Order Print");
            my_tree.print_preorder(my_tree.getRoot());
            Console.WriteLine(" ");

            Console.WriteLine("Delete Ops : " + my_tree.delete_node(23).getElemen());
            Console.WriteLine(" ");
            
            Console.WriteLine("Pre Order Print (Sesudah dihapus)");
            my_tree.print_preorder(my_tree.getRoot());
        }
    }
}