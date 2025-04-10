using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace record1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person("Windah", 30);
            Console.WriteLine("Nama ku adalah " + somebody.getName());

            somebody.setName("Ilham");
            Console.WriteLine("Nama mu sekarang adalah: " + somebody.getName());
        }
    }
}
