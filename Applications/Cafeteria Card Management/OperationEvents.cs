using System;
namespace Cafeteria_Card_Management
{
    public delegate void EventManager();
    public static partial class Operations
    {
        public static event EventManager starter,newRegistration,login,subMenu,showProfile,foodOrder,cancelOrder,orderHistory;
        public static void Starter()
        {
            Subscribe();
            starter();
        }
        public static void Subscribe()
        {
            starter+=new EventManager(Files.Create);
            starter+=new EventManager(Files.Read);
            starter+=new EventManager(Operations.MainMenu);
            starter+=new EventManager(Files.Write);
            newRegistration=new EventManager(Operations.NewRegistration);
            login=new EventManager(Operations.LoginMenu);
            subMenu=new EventManager(Operations.SubMenu);
            showProfile=new EventManager(Operations.ShowCustomerProfile);
            foodOrder=new EventManager(Operations.FoodOrder);
            cancelOrder=new EventManager(Operations.CancelOrder);
            orderHistory=new EventManager(Operations.OrderHistory);

        }
    }
}