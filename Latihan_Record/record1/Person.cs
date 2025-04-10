using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace record1
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

    }
}