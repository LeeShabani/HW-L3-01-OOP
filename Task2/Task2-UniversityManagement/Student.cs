using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityManagement
{
    public class Student : Person
    {
        public string Major { get; set; }

        public int StudentID { get; init; }


        public Student(string name, int age, string lastName, string major, int studentID) : base(name, age, lastName)
        {
            major = Major;
            StudentID = studentID;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Hi i'm {Name} {LastName} and I'm {Age} years old");
            Console.Write($" my major is {Major} and my studen ID is {StudentID}");
        }
    }
}
