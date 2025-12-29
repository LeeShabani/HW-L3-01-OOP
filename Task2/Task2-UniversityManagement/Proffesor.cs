
using System;

namespace Task2_UniversityManagement
{
    public class Proffesor : Person

    {
        public int ProffesorID { get; init; }
        public string Subject { get; set; }

        public Proffesor(string name, int age, string lastName, int proffesorID, string subject) : base(name, age, lastName)
        {
            ProffesorID = proffesorID;
            Subject = subject;

        }


        public virtual void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"I teach {Subject} and my ID is {ProffesorID}");
        }

    }
}
