using System;
namespace MovieTicketBooking
{
//     4.	Booking Details
// Properties: 
// •	BookingID (Auto Increment – BID7001)
// •	UserID
// •	MovieID
// •	TheatreID
// •	SeatCount
// •	TotalAmount
// •	BookingStatus (Enum type – Booked, Cancelled)
    public enum BookingStatus{Default,Booked,Cancelled}

    public class BookingDetails
    {
        private static int s_bookingID=7000;
        public string BookingID { get; set; }
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int SeatCount{get;set;}
        public double TotalAmount { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            MovieID=movieID;
            TheatreID=theatreID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|",BookingID,UserID,MovieID,TheatreID,SeatCount,TotalAmount,BookingStatus);
        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserID=values[1];
            MovieID=values[2];
            TheatreID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6],true);
        }
        
        
        
        
    }
}