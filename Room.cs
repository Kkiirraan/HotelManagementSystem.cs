using System;

namespace RoomNamespace
{
    class Room 
    {
        public int RoomNumber{get;set;}
        public bool IsVacant{get;set;}

        public Room(int roomNumber)
        {
            RoomNumber=roomNumber;
            IsVacant=true; // by default the room is vacant
        }
        public override string ToString()
        {
            return string.Format($"Room {RoomNumber} - {(IsVacant ?"Vacant":"Occupied")}");
        }
    }
}