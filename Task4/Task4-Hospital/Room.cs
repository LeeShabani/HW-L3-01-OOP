using System.Collections.Generic;

namespace ConsoleApp9
{
    class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>();
        }

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
                throw new RoomFullException($"Room {RoomNumber} is full");

            Patients.Add(patient);
        }
    }

}
