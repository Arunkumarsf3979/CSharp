namespace MovieTicketBooking
{
    
// 5.	Theatre Details:
// Properties: 
// •	TheatreID(Auto Increment – TID301)
// •	TheatreName
// •	TheatreLocation

    public class TheatreDetails
    {
        private static int s_theatreID=300;
        public string TheatreID { get; set; }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }
        public TheatreDetails(string TheatreName,string TheatreLocation)
        {
            s_theatreID++;
            TheatreID="TID"+s_theatreID;
            this.TheatreName=TheatreName;
            this.TheatreLocation=TheatreLocation;
        }
        public TheatreDetails(string data)
        {
            string[] values=data.Split(',');
            s_theatreID=int.Parse(values[0].Remove(0,3));
            TheatreID=values[0];
            TheatreName=values[1];
            TheatreLocation=values[2];
        }
        public void ShowTheatreDetails()
        {
            System.Console.WriteLine("|{0}|{1}|{2}|",TheatreID,TheatreName,TheatreLocation);
        }
        
        
        
        
    }
}