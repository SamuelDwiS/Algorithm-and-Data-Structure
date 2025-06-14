using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Graph
{
    public class graph
    {
        private int maxVertex = 10;
        private char[] vertexList;
        private int[,] adjancencyMatrix;
        private int countVertex = 0;

        public graph()
        {
            // untuk meng-set nilai awal atribut
            vertexList = new char[maxVertex];
            adjancencyMatrix = new int[maxVertex, maxVertex];
            countVertex = 0;

            for (int i = 0; i < vertexList.GetLength(0); i++)
            {
                for (int j = 0; j < vertexList.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        adjancencyMatrix[i, j] = 0;
                    }
                    else
                    {
                        adjancencyMatrix[i, j] = -1;
                    }
                }
            }
        }

        public void addVertex(char node)
        {
            vertexList[countVertex++] = node;
        }

        private int indexVertex(char node)
        {
            for (int i = 0; i < countVertex; i++)
            {
                if (vertexList[i] == node)
                {
                    return i;
                }
            }
            return -1;
        }

        public void addEdge(char a, char b, int c)
        {
            adjancencyMatrix[indexVertex(a), indexVertex(b)] = c;
            adjancencyMatrix[indexVertex(b), indexVertex(a)] = c;
        }

        public int get_weight(char a, char b)
        {
            return adjancencyMatrix[indexVertex(a), indexVertex(b)];
        }

        public void BFS_Traversal(int seed)
        {
            Queue antrian_ku = new Queue();

            // Memasukkan nilai index terkecil
            antrian_ku.Enqueue(vertexList[seed]);

            // Inisialisasi variable visit bernilai false
            Boolean[] visit = new Boolean[countVertex];
            for (int i = 0; i < visit.Length; i++)
            {
                visit[i] = false;
            }

            int x;
            while (antrian_ku.Count > 0)
            {
                x = indexVertex((char)antrian_ku.Dequeue());
                // jika visit dengan index ke x sama dengan true, maka lewatkan saja

                if (visit[x] == true)
                {

                }
                else
                {
                    // Jika visit ke seed tidak sama dengan true, kerjakan langka dibawah ini
                    Console.Write(vertexList[x] + " ");
                    visit[x] = true;

                    // Masukkan neighbor kedalam Queue
                    for (int i = 0; i < countVertex; i++)
                    {
                        if (adjancencyMatrix[indexVertex(vertexList[x]), i] > 0)
                        {
                            antrian_ku.Enqueue(vertexList[i]);
                        }
                    }
                }
            }
            Console.WriteLine(" ");
        }

        public void DFS_Traversal(int seed)
        {
            Stack tumpukan_ku = new Stack();

            // Memasukkan nilai index terkecil
            tumpukan_ku.Push(vertexList[seed]);

            // Inisialisasikan variabel visit bernilai false
            Boolean[] visit = new Boolean[countVertex];
            for (int i = 0; i < visit.Length; i++)
            {
                visit[i] = false;
            }

            int x;
            while (tumpukan_ku.Count > 0)
            {
                x = indexVertex((char)tumpukan_ku.Pop());

                // Jika visit dengan index ke x sama dengan true, maka lewatkan saja

                if (visit[x] == true)
                {

                }
                else
                {
                    // Jika visit ke seed tidak sama dengan true, kerjakan langkah di bawah ini
                    Console.Write(vertexList[x] + " ");
                    visit[x] = true;

                    // Masukkan neighbor kedalam Stack
                    for (int i = countVertex - 1; i >= 0; i--)
                    {
                        if (adjancencyMatrix[indexVertex(vertexList[x]), i] > 0)
                        {
                            tumpukan_ku.Push(vertexList[i]);
                        }
                    }
                }
            }
            Console.WriteLine(" ");
        }

        public void print_adjacency_matrix()
        {
            for (int baris = 0; baris < countVertex; baris++)
            {
                for (int kolom = 0; kolom < countVertex; kolom++)
                {
                    Console.Write($"{adjancencyMatrix[baris, kolom]}\t");
                }
                Console.WriteLine(" ");
            }
        }
    }
}