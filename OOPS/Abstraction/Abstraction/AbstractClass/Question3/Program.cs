using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        OnlineTicket online=new OnlineTicket("AGS",300,TicketType.Online,4);
        OfflineTicket offline=new OfflineTicket("AGS",300,TicketType.Offline,4);
        System.Console.WriteLine("                Online Book Ticket");
        online.BookTicket();
        online.ShowTicket();
        System.Console.WriteLine("                 Offline Book Ticket");
        online.BookTicket();
        online.ShowTicket();
    }
}