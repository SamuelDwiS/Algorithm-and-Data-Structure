using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graph
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            graph my_graph = new graph();
            my_graph.addVertex('A');
            my_graph.addVertex('B');
            my_graph.addVertex('C');
            my_graph.addVertex('D');
            my_graph.addVertex('E');
            my_graph.addVertex('F');

            my_graph.addEdge('A', 'B', 1);
            my_graph.addEdge('A', 'C', 1);
            my_graph.addEdge('A', 'D', 1);
            my_graph.addEdge('B', 'C', 1);
            my_graph.addEdge('B', 'E', 1);
            my_graph.addEdge('C', 'E', 1);
            my_graph.addEdge('C', 'F', 1);
            my_graph.addEdge('C', 'D', 1);
            my_graph.addEdge('F', 'D', 1);

            Console.WriteLine("BFS Traversal");
            my_graph.BFS_Traversal(0);
            Console.WriteLine(" ");

            Console.WriteLine("DFS Traversal");
            my_graph.DFS_Traversal(0);
            Console.WriteLine(" ");

        }

    }
}