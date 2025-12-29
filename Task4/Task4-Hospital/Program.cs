using System;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Hospital hospital = new Hospital();

                hospital.Rooms.Add(new Room(101, 2));
                hospital.Rooms.Add(new Room(102, 1));

                Patient p1 = new Patient("Ali", 30, 123456, 1);
                Patient p2 = new Patient("Sara", 25, 654321, 2);

                Doctor doctor = new Doctor("Dr. Smith", 45, 999999, 10, "Cardiology");

                hospital.AdmitPatient(p1);
                hospital.AdmitPatient(p2);

                doctor.Diagnose(p1, "Flu");
                doctor.Diagnose(p2, "Cold");

                Console.WriteLine("Patient Details");
                p1.GetDetails();

                p2.GetDetails();

                hospital.DischargePatient(p1);
            }
        }
    }
}
