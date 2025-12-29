using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    public class Patient : Person
    {
        public Patient(string name, int age, int nationalID, int patientID) : base(name, age, nationalID)
        {
            PatientID = patientID;
            MedicalHistory = new List<string>();
        }
        public int PatientID { get; set; }
        public List<string> MedicalHistory { get; set; }

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine("Medical History:");
            if (MedicalHistory.Count == 0)
                Console.WriteLine("No records");
            else
                foreach (string item in MedicalHistory)
                    Console.WriteLine($"- {item}");
        }
    }
}