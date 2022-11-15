namespace MovieTicketBooking
{
    public delegate void EventManager();
    public static partial class Operations
    {
        public static event EventManager starter;
        public static event EventManager newRegistration;
        public static void Starter()
        {
            Subscribe();
            starter();
        }
        public static void Subscribe()
        {
            starter=new EventManager(Files.Create);
            starter+=new EventManager(Files.Read);
            starter+=new EventManager(MainMenu);
            starter+=new EventManager(Files.Write);
        }
    }
}