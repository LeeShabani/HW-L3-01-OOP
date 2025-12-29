using System;

namespace ConsoleApp9
{
    class RoomFullException : Exception
    {
        public RoomFullException(string message) : base(message)
        {
        }
    }
}