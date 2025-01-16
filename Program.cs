using System;
using HotelmanagementNamespace;
using HotelNameSpace;

namespace ProgramNamespace
{
    class program 
    {
        public static void Main(string[] args)
        {
            HotelManagementSystem system = new HotelManagementSystem();

            while (true)
            {
                Console.WriteLine("\nHotel Management System Menu:");
                Console.WriteLine("1. Add Hotel");
                Console.WriteLine("2. Add Room to Hotel");
                Console.WriteLine("3. Allocate Room");
                Console.WriteLine("4. Display Rooms in Hotel");
                Console.WriteLine("5. Display All Hotels");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Hotel Name: ");
                        string hotelName = Console.ReadLine();
                        Console.Write("Enter Hotel Location: ");
                        string hotelLocation = Console.ReadLine();
                        system.AddHotel(hotelName, hotelLocation);
                        break;

                    case 2:
                        Console.Write("Enter Hotel Name: ");
                        string hotelNameForRoom = Console.ReadLine();
                        Hotel hotelForRoom = system.GetHotel(hotelNameForRoom);
                        if (hotelForRoom != null)
                        {
                            Console.Write("Enter Room Number: ");
                            int roomNumber = int.Parse(Console.ReadLine());
                            hotelForRoom.AddRoom(roomNumber);
                        }
                        else
                        {
                            Console.WriteLine("Hotel not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Hotel Name: ");
                        string hotelNameForAllocation = Console.ReadLine();
                        Hotel hotelForAllocation = system.GetHotel(hotelNameForAllocation);
                        if (hotelForAllocation != null)
                        {
                            Console.Write("Enter Guest Name: ");
                            string guestName = Console.ReadLine();
                            hotelForAllocation.AllocateRoom(guestName);
                        }
                        else
                        {
                            Console.WriteLine("Hotel not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Hotel Name: ");
                        string hotelNameForDisplay = Console.ReadLine();
                        Hotel hotelForDisplay = system.GetHotel(hotelNameForDisplay);
                        if (hotelForDisplay != null)
                        {
                            hotelForDisplay.DisplayRooms();
                        }
                        else
                        {
                            Console.WriteLine("Hotel not found.");
                        }
                        break;

                    case 5:
                        system.DisplayHotels();
                        break;

                    case 6:
                        Console.WriteLine("Exiting Hotel Management System.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}