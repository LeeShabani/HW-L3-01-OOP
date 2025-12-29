using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityManagement
{
    public class Person
    {
        public string Name { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }

        public Person(string name, int age , string lastName)
        {
            Name = name;
            Age = age;
            LastName = lastName;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Hi i'm {Name} {LastName} and I'm {Age} years old");
        }

    }
}
