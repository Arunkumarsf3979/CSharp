using System;
using System.Collections.Generic;
namespace MetroCardManagement
{
    public static partial class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TravelHistory> travelList=new List<TravelHistory>();
        public static List<TicketFairDetails> ticketFairList=new List<TicketFairDetails>();
        private static UserDetails currentUser;
        public static void MainMenu()
        {
            int choice;
            do{
                System.Console.WriteLine("1.New User Registration");
                System.Console.WriteLine("2.Login User");
                System.Console.WriteLine("3.Exit");
                System.Console.Write("Enter your choice ");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome to New User Registration");
                        NewRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Welcome to Login User");
                        LoginMenu();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exited from the application");
                        break;
                    }
                }
            }while(choice!=3);
        }
        private static void NewRegistration()
        {
            System.Console.Write("Enter Your Name               :");
            string name=Console.ReadLine();
            System.Console.Write("Enter Your Phone Number   :");
            string phone=Console.ReadLine();
            UserDetails newUser=new UserDetails(name,phone);
            System.Console.WriteLine("Your generated card number is"+newUser.CardNumber);
            userList.Add(newUser);
        }
        private static void LoginMenu()
        {
            System.Console.WriteLine("Enter the card Number    :");
            string cardNumber=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(user.CardNumber.Equals(cardNumber))
                {
                    currentUser=user;
                    flag=false;
                    SubMenu();
                }
            }
            if(flag){
                System.Console.WriteLine("Invalid card number....");
            }
        }
        private static void SubMenu()
        {
            int choice;
            do{
                System.Console.WriteLine("a.Balance check");
                System.Console.WriteLine("b.Recharge");
                System.Console.WriteLine("c.View Travel History");
                System.Console.WriteLine("d.Travel");
                System.Console.WriteLine("e.Go to main menu");
                System.Console.Write("Enter your choice     :");
                choice =Console.ReadLine().ToLower()[0];
                switch(choice)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Welcome to balance check");
                        BalanceCheck();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Welcome to Recharge");
                        Recharge();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Welcome to View Travel History");
                        ViewTravelHistory();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Travel");
                        Travel();
                        break;
                    }
                    case 'e':
                    {
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid option...");
                        break;
                    }
                }
                
            }while(choice!='e');
        }
        private static void BalanceCheck()
        {
            System.Console.WriteLine("Your balance is "+currentUser.Balance);
        }
        private static void Recharge()
        {
            System.Console.WriteLine("Enter the amount to be Recharged    :");
            int amount=Convert.ToInt32(Console.ReadLine());
            currentUser.Balance+=amount;
            System.Console.WriteLine("Recharged successfully and your available balance is "+currentUser.Balance);
        }
        private static void ViewTravelHistory()
        {
            bool flag=true;
            foreach(TravelHistory travel in travelList)
            {
                if(travel.CardNumber.Equals(currentUser.CardNumber))
                {
                    flag=false;
                    travel.ShowTravelDetails();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("There is no travel history...");
            }
        }
        private static void Travel()
        {
            bool flag=true;
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                ticket.ShowTicketFairDetails();
            }
            System.Console.Write("Enter the ticketID     :");
            string ticketID=Console.ReadLine().ToUpper();
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                if(ticket.TicketID.Equals(ticketID))
                {
                    flag=false;
                    if(currentUser.Balance>ticket.TicketPrice)
                    {
                        currentUser.Balance-=ticket.TicketPrice;
                        System.Console.WriteLine("Ticket booked successfully...");
                        TravelHistory newTravel=new TravelHistory(currentUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Today,ticket.TicketPrice);
                        travelList.Add(newTravel);
                        return;
                    }
                    else{
                        System.Console.WriteLine("Recharge Immediately...");
                        Recharge();
                    }
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Ivalid Ticket id");
            }
        }
    }
}