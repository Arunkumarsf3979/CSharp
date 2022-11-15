namespace Question3
{
//     Class offlineticket inherit ticket
// overridden property : TicketType -online, offline, seat number
// overridden method: book ticket, show ticket

    public class OfflineTicket:Ticket
    {
        public override TicketType TicketType { get ;set; }
        public override int SeatNumber{get;set;}
        public OfflineTicket(string theatername,int ticketPrice,TicketType ticketType,int seatNumber)
        {  
            TheaterName=theatername;
            TicketPrice=ticketPrice;
            TicketType=ticketType;
            SeatNumber=seatNumber;
        }
        public override void BookTicket()
        {
            System.Console.WriteLine("Booked Successfully....");
        }
        public override void ShowTicket()
        {
            System.Console.WriteLine("Theatre name    :"+TheaterName);
            System.Console.WriteLine("TicketPrice     :"+TicketPrice);
            System.Console.WriteLine("TicketID        :"+TicketID);
            System.Console.WriteLine("TicketType      :"+TicketType);
            System.Console.WriteLine("SeatNumber      :"+SeatNumber);
        }
    }
}