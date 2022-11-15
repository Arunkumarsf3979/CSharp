using System;
namespace HotelRoomBooking
{
    public delegate void EventManager();
    public partial class Operations
    {
        public static event EventManager events;
        public static void Events()
        {
            Subscribe();
            events();
        }
        public static void Subscribe()
        {
            events+=new EventManager(Files.Create);
            events+=new EventManager(Files.Read);
            events+=new EventManager(Operations.MainMenu);
            events+=new EventManager(Files.Write);
        }
    }
}