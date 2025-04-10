using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review3
{
    public class review3
    {
        public record Employee(string nama, int age, string position);

        public static void Main(string[]args)
        {
            Employee[] pegawai =
            {
                new Employee("Samuel", 30, "Software Engineer"),
                new Employee("Ilham", 28, "Data Analyst"),
                new Employee("Kurniawan", 35, "Project Manager")
            };

            for(int i = 0; i < pegawai.Length; i++) 
            {
                Console.WriteLine("Nama: " + pegawai[i].nama);
                Console.WriteLine("Nama: " + pegawai[i].age);
                Console.WriteLine("Nama: " + pegawai[i].position);
                garis(26, '-');
            }
        } 

        static void garis(int x, char y)
        {
            for(int i = 0; i < x; i++)
            {
                Console.Write(y);
            }
            Console.WriteLine(" ");
        }
    }
}