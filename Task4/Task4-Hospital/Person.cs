using System;

namespace ConsoleApp9
{
    public class Person
    {
        public Person(string name, int age, int nationalID)
        {
            Name = name;
            Age = age;
            NationalID = nationalID;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int NationalID { get; init; }


        public virtual void GetDetails()
        {
            Console.WriteLine($"Personal information :");
            Console.WriteLine($"Name : {Name} Age : {Age} National ID: {NationalID}");
        }
    }
}