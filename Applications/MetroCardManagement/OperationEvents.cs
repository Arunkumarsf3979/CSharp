namespace MetroCardManagement
{
    public delegate void EventManager();
    public static partial class Operations
    {
        public static event EventManager starter;
        public static event EventManager balanceCheck,recharge,viewTravelHistory,travel;
        public static void Starter()
        {
            Subscribe();
            starter();
        }
        public static void Subscribe()
        {
            starter+=new EventManager(Files.Create);
            starter+=new EventManager(Files.Read);
            starter+=new EventManager(MainMenu);
            starter+=new EventManager(Files.Write);
            balanceCheck=new EventManager(BalanceCheck);
            recharge=new EventManager(Recharge);
            viewTravelHistory=new EventManager(ViewTravelHistory);
            travel=new EventManager(Travel);
        }

    }
}