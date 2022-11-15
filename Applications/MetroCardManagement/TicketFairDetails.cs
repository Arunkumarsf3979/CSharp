namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        private static int s_TicketID=100;
        public string TicketID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int TicketPrice { get; set; }
        
        public TicketFairDetails(string FromLocation,string ToLocation,int TicketPrice)
        {
            s_TicketID++;
            TicketID="MR"+s_TicketID;
            this.FromLocation=FromLocation;
            this.ToLocation=ToLocation;
            this.TicketPrice=TicketPrice;
        }
        public TicketFairDetails(string data)
        {
            string []values=data.Split(',');
            s_TicketID=int.Parse(values[0].Remove(0,2));
            TicketID=values[0];
            FromLocation=values[1];
            ToLocation=values[2];
            TicketPrice=int.Parse(values[3]);
        }
        public void ShowTicketFairDetails()
        {
            System.Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}",TicketID,FromLocation,ToLocation,TicketPrice);
        }
        
        
    }
}