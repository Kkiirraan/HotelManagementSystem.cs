using System;
using RoomNamespace;

namespace HotelNameSpace
{
    class Hotel 
    {
        public string Name{get;set;}
        public string Location{get;set;}
        public List<Room> Rooms;
        public Hotel(string name,string location)
        {
            Name=name;
            Location=location;
            Rooms=new List<Room>();
        }
        public void AddRoom(int roomNumber)
        {
            if(Rooms.Any(r=>r.RoomNumber==roomNumber))
            {
                Console.WriteLine($"Room: {roomNumber} already has exits in {Name}.");
                return;
            }
            Rooms.Add(new Room(roomNumber));
            Console.WriteLine($"Room {roomNumber} added to hotel {Name}.");
        }
        public bool AllocateRoom(string guestName)
        {
            Room vacantRoom=Rooms.FirstOrDefault(r=>r.IsVacant);
            if(vacantRoom!=null)
            {
                vacantRoom.IsVacant=false;
                Console.WriteLine($"Room {vacantRoom.RoomNumber} allocated to {guestName}");
                return true;
            }
            else
            {
                Console.WriteLine($"No vacant rooms available in {Name}");
                return false;
            }
        }
        public void DisplayRooms()
        {
            Console.WriteLine($"Rooms in {Name}, {Location}");
            foreach(var room in Rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}