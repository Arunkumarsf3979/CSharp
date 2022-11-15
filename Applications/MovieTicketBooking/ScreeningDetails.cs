namespace MovieTicketBooking
{
//     7.	Screening Details: 
// Properties: 
// •	Movie ID 
// •	TheatreID
// •	NoOfSeatsAvailable
// •	Ticket Price

    public class ScreeningDetails
    {
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int NoOfSeatsAvailable { get; set; }
        public double TicketPrice { get; set; }
        public ScreeningDetails(string movieID,string theatreID,int noOfSeatsAvailable,double ticketPrice)
        {
            MovieID=movieID;
            TheatreID=theatreID;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string[] values=data.Split(',');
            MovieID=values[0];
            TheatreID=values[1];
            NoOfSeatsAvailable=int.Parse(values[3]);
            TicketPrice=double.Parse(values[2]);
        }
        
        
        
        
    }
}