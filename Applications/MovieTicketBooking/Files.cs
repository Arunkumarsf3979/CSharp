using System;
using System.IO;
namespace MovieTicketBooking
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                System.Console.WriteLine("Folder not present...");
                Directory.CreateDirectory("MovieTicketBooking");
                System.Console.WriteLine("Folder created Successfully..");
            }
            else
            {
                System.Console.WriteLine("Folder present...");
            }
            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MovieTicketBooking/UserDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MovieTicketBooking/BookingDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
            if(!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MovieTicketBooking/TheatreDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MovieTicketBooking/MovieDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MovieTicketBooking/ScreeningDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
        }
        public static void Write()
        {
            string[] userInfo=new String[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userInfo[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].Age+','+Operations.userList[i].PhoneNumber+','+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",userInfo);

            string[] bookingInfo=new String[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingInfo[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].UserID+','+Operations.bookingList[i].MovieID+','+Operations.bookingList[i].TheatreID+','+Operations.bookingList[i].SeatCount+','+Operations.bookingList[i].TotalAmount+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookingInfo);

            string[] movieInfo=new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                movieInfo[i]=Operations.movieList[i].MovieID+','+Operations.movieList[i].MovieName+','+Operations.movieList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movieInfo);

            string[] theatreInfo=new string[Operations.theatreList.Count];
            for(int i=0;i<Operations.theatreList.Count;i++)
            {
                theatreInfo[i]=Operations.theatreList[i].TheatreID+','+Operations.theatreList[i].TheatreName+','+Operations.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv",theatreInfo);

            string[] screeningInfo=new string[Operations.screeningList.Count];
            for(int i=0;i<Operations.screeningList.Count;i++)
            {
                screeningInfo[i]=Operations.screeningList[i].MovieID+','+Operations.screeningList[i].TheatreID+','+Operations.screeningList[i].TicketPrice+','+Operations.screeningList[i].NoOfSeatsAvailable;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screeningInfo);
        }
        public static void Read()
        {
            string []userInfo=File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            for(int i=0;i<userInfo.Length;i++)
            {
                UserDetails user=new UserDetails(userInfo[i]);
                Operations.userList.Add(user);
            }

            string[] bookingInfo=File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }

            string[] movieInfo=File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string data in movieInfo)
            {
                MovieDetails movie=new MovieDetails(data);
                Operations.movieList.Add(movie);
            }

            string[] theatreInfo=File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            foreach(string data in theatreInfo)
            {
                TheatreDetails theatre=new TheatreDetails(data);
                Operations.theatreList.Add(theatre);
            }

            string[] screeningInfo=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string data in screeningInfo)
            {
                ScreeningDetails screening=new ScreeningDetails(data);
                Operations.screeningList.Add(screening);
            }
        }
    }
}