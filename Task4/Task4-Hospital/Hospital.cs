using System;
using System.Collections.Generic;

namespace ConsoleApp9
{

    class Hospital
    {
        public List<Room> Rooms { get; set; }

        public Hospital()
        {
            Rooms = new List<Room>();
        }

        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    Console.WriteLine($"Patient {patient.Name} admitted to room {room.RoomNumber}");
                    return;
                }
                catch { }
            }

            Console.WriteLine("No available room for this patient!");
        }

        public void DischargePatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    Console.WriteLine($"Patient {patient.Name} discharged successfully");
                    return;
                }
            }

            Console.WriteLine("Patient not found in hospital!");
        }

    }
}
