using System;
using HotelNameSpace;

namespace HotelmanagementNamespace
{
    class HotelManagementSystem
    {
        private List<Hotel> Hotels;

        public HotelManagementSystem()
        {
            Hotels=new List<Hotel>();
        }
        public void AddHotel(string name,string location)
        {
            if(Hotels.Any(h=>h.Name.Equals(name,StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Hotel {name} already exits.");
                return;
            }
            Hotels.Add(new Hotel(name,location));
            Console.WriteLine($"Hotel {name} added successfully");
        }
        public Hotel GetHotel(string name)
        {
            return Hotels.FirstOrDefault(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayHotels()
        {
            Console.WriteLine("Available Hotels:");
            foreach (var hotel in Hotels)
            {
                Console.WriteLine($"Hotel: {hotel.Name}, Location: {hotel.Location}");
            }
        }
    }
}