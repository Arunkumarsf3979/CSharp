using System;
namespace HotelRoomBooking
{
//     Properties:
// •	BookingID (Auto increment-BID101)
// •	UserId
// •	TotalPrice 
// •	DateOfBooking
// •	BookingStatus (Default, Initiated, Booked, Cancelled)

    public class BookingDetails
    {
        private static int s_bookingID=100;
        public string BookingID { get; }
        
        
        public string UserID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public BookingDetails(string UserID,double TotalPrice,DateTime DateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            this.UserID=UserID;
            this.TotalPrice=TotalPrice;
            this.DateOfBooking=DateOfBooking;
            this.BookingStatus=bookingStatus;
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("|{0,-15}|{1,-14}|{2,-16}|{3,-23}|{4,-19}|",BookingID,UserID,TotalPrice,DateOfBooking,BookingStatus);
        }
        
        
        
    }
}