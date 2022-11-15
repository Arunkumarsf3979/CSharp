using System;
namespace HotelRoomBooking
{
    //     Room Selection Class should have below properties.
    // 		Properties:
    // •	SelectionID (Auto increment-SID1001)
    // •	RoomID
    // •	BookingID
    // •	StayingDateFrom
    // •	StayingDateTo
    // •	Price
    // •	NumberOfDays
    // •	BookingStatus (Default, Initiated, Booked, Cancelled)
    public enum BookingStatus { Default, Initiated, Booked, Cancelled }
    public class RoomSelection
    {
        private static int s_selectionID = 1000;
        public string SelectionID { get;  }
        public string RoomID { get; set; }
        public string BookingID { get; set; }
        public DateTime StayingDateFrom { get; set; }
        public DateTime StayingDateTo { get; set; }
        public double Price { get; set; }
        public double NumberOfDays { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public RoomSelection( string bookingID, string roomID,DateTime stayingDateFrom, DateTime stayingDateTo, double price, double numberOfDays, BookingStatus bookingStatus)
        {
            s_selectionID++;
            SelectionID="SID"+s_selectionID;
            this.RoomID = roomID;
            this.BookingID = bookingID;
            this.StayingDateFrom = stayingDateFrom;
            this.StayingDateTo = stayingDateTo;
            this.Price = price;
            this.NumberOfDays = numberOfDays;
            this.BookingStatus = bookingStatus;

        }
        
        public void ShowRoomSelectionList()
        {
            System.Console.WriteLine("|{0,-15}|{1,-13}|{2,-10}|{3,-25}|{4,-23}|{5,-9}|{6,-16}|{7,-17}|",SelectionID,BookingID,RoomID,StayingDateFrom,StayingDateTo,Price,NumberOfDays,BookingStatus);
        }









    }
}