using System;

namespace ConsoleApp9
{

    class Doctor : Person
    {
        public int DoctorId { get; set; }
        public string Specialization { get; set; }

        public Doctor(string name, int age, int nationalID, int doctorId, string specialization) : base(name, age, nationalID)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory(disease);
            Console.WriteLine($"Diagnosis '{disease}' added for patient {patient.Name}");
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"Doctor ID: {DoctorId}");
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}

}