using System;
namespace MetroCardManagement
{
//     a.	TravelId (Auto Generated -TID101)
// b.	Card Number
// c.	FromLocation
// d.	ToLocation
// e.	Date
// f.	Travel Cost

    public class TravelHistory
    {
        private static int s_TravelID=100;
        public string TravelID { get; set; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public int TravelCost { get; set; }
        public TravelHistory(string CardNumber,string FromLocation,string ToLocation,DateTime Date,int TravelCost)
        {
            s_TravelID++;
            TravelID="TID"+s_TravelID;
            this.CardNumber=CardNumber;
            this.FromLocation=FromLocation;
            this.ToLocation=ToLocation;
            this.Date=Date;
            this.TravelCost=TravelCost;
        }
        public void ShowTravelDetails()
        {
            System.Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",TravelID,CardNumber,FromLocation,ToLocation,Date.ToString("dd/MM/yyyy"),TravelCost);
        }
        public TravelHistory(string data)
        {
            string []values=data.Split(',');
            s_TravelID=int.Parse(values[0].Remove(0,3));
            TravelID=values[0];
            CardNumber=values[1];
            FromLocation=values[2];
            ToLocation=values[3];
            Date=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            TravelCost=int.Parse(values[5]);
        }
        
        
        
        
    }
}