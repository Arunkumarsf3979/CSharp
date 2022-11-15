using System;
using System.Collections.Generic;
namespace MovieTicketBooking
{
    public static partial class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList=new List<ScreeningDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static UserDetails currentUser;
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
            bool temp;
            System.Console.Write("Enter your Name                     :");
            string name=Console.ReadLine();
            System.Console.Write("Enter your Age                      :");
            int age;
            temp=int.TryParse(Console.ReadLine(),out age);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input......");
                System.Console.Write("Enter your Age                      :");
                temp=int.TryParse(Console.ReadLine(),out age);
            }
            System.Console.Write("Enter your Phone Number             :");
            long phoneNumber;
            temp=long.TryParse(Console.ReadLine(),out phoneNumber);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input......");
                System.Console.Write("Enter your Phone Number             :");
                temp=long.TryParse(Console.ReadLine(),out phoneNumber);
            }
            System.Console.Write("Enter your Wallet Balance           :");
            double walletBalance;
            temp=double.TryParse(Console.ReadLine(),out walletBalance);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input......");
                System.Console.Write("Enter your Wallet Balance           :");
                temp=int.TryParse(Console.ReadLine(),out age);
            }
            UserDetails user=new UserDetails(name,age,phoneNumber,walletBalance);
            userList.Add(user);
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine("Regisrtred Successfully.....");
            Console.ResetColor();
            System.Console.WriteLine("YOUR GENERATED USERID IS "+user.UserID);
        }
// a.	Ticket Booking
// b.	Ticket Cancellation 
// c.	Booking History
// d.	Wallet Recharge
// e.	Exit

        private static void LoginMenu()
        {
            bool flag=true;
            System.Console.Write("Enter the UserId                  :");
            string userID=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(userID.Equals(user.UserID))
                {
                    flag=false;
                    currentUser=user;
                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("User not found....");
            }
        }
        private static void SubMenu()
        {
            int choice;
            do{
                System.Console.WriteLine("a.Ticket Booking");
                System.Console.WriteLine("b.Ticket Cancellation");
                System.Console.WriteLine("c.Booking History");
                System.Console.WriteLine("d.Wallet Recharge");
                System.Console.WriteLine("e.Exit");
                System.Console.Write("Enter your choice       :");
                choice=Console.ReadLine().ToLower()[0];
                switch(choice)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Welcome to Ticket Booking");
                        TicketBooking();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Welcome to Ticket Cancellation");
                        TicketCancellation();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Welcome to Booking History");
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Welcome to recharge wallet");
                        RechargeWallet();
                        break;
                    }
                    case 'e':
                    {
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }while(choice!='e');
        }
        private static void TicketBooking()
        {
            bool flag=true;
            bool flagForMovieID=true;
            string choice="";
            int seatsAvailable=0;
            // System.Console.WriteLine("|{0}|{1}|{2}|{3}|",);
            foreach(TheatreDetails theatre in theatreList)
            {
                theatre.ShowTheatreDetails();
            }
            System.Console.Write("Enter the TheatreID                   :");
            String theatreID=Console.ReadLine().ToUpper();
            foreach(TheatreDetails theatre in theatreList)
            {
                if(theatre.TheatreID.Equals(theatreID))
                {
                    flag=false;
                    foreach(ScreeningDetails screening in screeningList)
                    {
                        if(screening.TheatreID.Equals(theatreID))
                        {
                            foreach(MovieDetails movie in movieList)
                            {
                                if(movie.MovieID.Equals(screening.MovieID))
                                {
                                    movie.ShowMovieDetails();
                                }
                            }
                        }
                    }
                    System.Console.Write("Enter the MovieID                   :");
                    String movieID=Console.ReadLine().ToUpper();
                    foreach(MovieDetails movie in movieList)
                    {
                        if(movie.MovieID.Equals(movieID))
                        {
                            flagForMovieID=false;
                            System.Console.Write("Enter the number for seats to be booked   :");
                            int seats=Convert.ToInt32(Console.ReadLine());
                            foreach(ScreeningDetails screening in screeningList)
                            {
                                if(screening.MovieID.Equals(movieID)&&theatre.TheatreID.Equals(screening.TheatreID))
                                {
                                    seatsAvailable=screening.NoOfSeatsAvailable;
                                    // System.Console.WriteLine(screening.NoOfSeatsAvailable);
                                    if(seats<=screening.NoOfSeatsAvailable)
                                    {
                                        double totalAmount=screening.TicketPrice*seats+0.18*(screening.TicketPrice*seats);
                                        System.Console.Write("Do you want to confirm the order     :");
                                        choice=Console.ReadLine().ToLower();
                                        while(choice=="yes")
                                        {
                                            if(currentUser.WalletBalance>=totalAmount)
                                            {
                                                System.Console.WriteLine(totalAmount);
                                                currentUser.WalletBalance-=totalAmount;
                                                screening.NoOfSeatsAvailable-=seats;
                                                BookingDetails newBooking=new BookingDetails(currentUser.UserID,movieID,theatreID,seats,totalAmount,BookingStatus.Booked);
                                                bookingList.Add(newBooking);
                                                System.Console.WriteLine("Booked Successfully....");
                                                return;
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("Insufficient balance. Recharge Immediately...");
                                                System.Console.Write("Do you want to recharge your wallet   :");
                                                choice=Console.ReadLine().ToLower();
                                                if(choice=="yes")
                                                {
                                                    System.Console.Write("Enter the amount to be recharged     :");
                                                    double amount=Convert.ToDouble(Console.ReadLine());
                                                    currentUser.RechargeWallet(amount);
                                                    System.Console.WriteLine("Recharged successfully...");
                                                    System.Console.Write("Do you want to confirm the order     :");
                                                    choice=Console.ReadLine().ToLower();
                                                }
                                            }
                                        }
                                        if(choice!="yes")
                                        {
                                            System.Console.WriteLine("Booking failed.....");
                                        }
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Insufficient seats...Current Availability is "+seatsAvailable);
                                    }
                                }
                            }
                        }
                    }
                    if(flagForMovieID)
                    {
                        System.Console.WriteLine("MovieID is not found...");
                    }
                }
            }
            if(flag)
            {
                System.Console.WriteLine("TheatreID is not found....");
            }
        }
        private static void TicketCancellation()
        {
            bool flag=true;
            string choice="";
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.UserID.Equals(currentUser.UserID))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("There is no booking from the user....");
                flag=true;
                return;
            }
            System.Console.Write("Enter the booking order to be cancelled    :");
            string bookingID=Console.ReadLine().ToUpper();
            
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(bookingID)&&booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    flag=false;
                    
                    foreach(ScreeningDetails screening in screeningList)
                    {
                        if(screening.TheatreID.Equals(booking.TheatreID)&&screening.MovieID.Equals(booking.MovieID))
                        {
                            System.Console.Write("Do you want to confirm your cancellation(Cancellation Charges Rs 20)      :");
                            choice=Console.ReadLine().ToLower();
                            if(choice=="yes")
                            {
                                screening.NoOfSeatsAvailable+=booking.SeatCount;
                                currentUser.WalletBalance+=booking.TotalAmount-20;
                                System.Console.WriteLine("Ticket Cancelled successfully..");
                                booking.BookingStatus=BookingStatus.Cancelled;
                                return;
                            }
                        }
                    }            
                }
            }
            if(flag)
            {
                System.Console.WriteLine("User Not Found....");
            }
            
        }
        private static void BookingHistory()
        {
            bool flag=true;
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID.Equals(booking.UserID))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("There is no booking from the user....");
            }
        }
        private static void RechargeWallet()
        {
            System.Console.Write("Enter the amount to be recharged    :");
            double amount=Convert.ToInt32(Console.ReadLine());
            currentUser.RechargeWallet(amount);
            System.Console.WriteLine("Recharged Successfully...");
        }
    }

}