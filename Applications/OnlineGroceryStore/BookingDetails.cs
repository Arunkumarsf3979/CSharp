using System;
namespace OnlineGroceryStore
{
//     Properties: BookingID, CustomerID, TotalPrice, DateOfBooking, 
// Booking Status – Default, Initiated, Booked, Cancelled.
// Method: ShowBookingDetails
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        /// <summary>
        /// It is an unique id generated for each booking
        /// </summary>
        /// <value></value>
        public string BookingID { get; set; }
        /// <summary>
        /// Each customer has an unique id
        /// </summary>
        /// <value></value>
        public string CustomerID { get; set; }
        /// <summary>
        /// It holds the total price amount of booked rooms
        /// </summary>
        /// <value></value>
        public float TotalPrice { get; set; }
        /// <summary>
        /// Should pass when the rooms are booked
        /// </summary>
        /// <value></value>
        public DateTime DateOfBooking { get; set; }
        /// <summary>
        /// Confirm whether the rooms are booked or not
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// This belong to the class <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="customerID">Each customer has an unique id</param>
        /// <param name="totalPrice">It holds the total price amount of booked rooms</param>
        /// <param name="dateOfBooking">Should pass when the rooms are booked</param>
        /// <param name="bookingStatus">Confirm whether the rooms are booked or not</param>
        public BookingDetails(string customerID,float totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus; 
        }
        public BookingDetails(){}
        public BookingDetails(string data)
        {
            string[]values=data.Split(',');
            s_bookingID=Convert.ToInt32(values[0].Remove(0,3));
            BookingID=values[0];
            CustomerID=values[1];
            TotalPrice=Convert.ToSingle(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4],true);
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("|{0,-11}|{1,-12}|{2,-12}|{3,-15}|{4,-15}|",BookingID,CustomerID,TotalPrice,DateOfBooking.ToString("dd/MM/yyyy"),BookingStatus);
        }
    }
}