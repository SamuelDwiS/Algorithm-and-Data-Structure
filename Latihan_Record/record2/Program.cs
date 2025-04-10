using System;

namespace record2
{
    class Program
    {
        public record Person(string Name, int Age);
        static void Main(string[] args)
        {
            Person somebody = new Person("Windah", 30);
            Console.WriteLine("Nama ku adalah " + somebody.Name);

            Person somebody2 = somebody with{Name = "Ilham"};
            Console.WriteLine("Nama mu adalah " + somebody2.Name);
        }
    }
}