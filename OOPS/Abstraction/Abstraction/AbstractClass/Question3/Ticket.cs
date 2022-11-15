namespace Question3
{
    // Abstract class ticket
// Field : ticket id
// Property ticketID – TID100 , theatername, ticket price
// Abstract property : TicketType – (online, offline),  seat number
// Abstract method: book ticket, show ticket

    public enum TicketType{Default,Online,Offline}
    public abstract class Ticket
    {
        private static int s_ticketID=100;
        public string TicketID{get{s_ticketID++;return "TID"+s_ticketID;}}
        public string TheaterName { get; set; }
        public int TicketPrice { get; set; }
        public abstract TicketType  TicketType { get; set; }
        public abstract int SeatNumber { get; set; }
        public abstract void BookTicket();
        public abstract void ShowTicket();
        
        
        
        
        
        
        
    }
}