using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Hotel
{
    class Room
    {
        //public int RoomNum { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Room(string name, string email)
        {
            //RoomNum = roomNum;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
