using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R3
{
    public class MainClass_R3
    {
        static void count(int index)
        {
            if (index > 2)
            {
                count(index + 1);
            }
            Console.WriteLine(index);
        }
        static void Main(string[] args)
        {
            count(3);
        }
    }
}