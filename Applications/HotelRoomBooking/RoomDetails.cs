namespace HotelRoomBooking
{
    //     Properties: 
    // •	RoomID(Auto Increment – RID101)
    // •	RoomType (Enum – Standard, Delux, Suit)
    // •	NumberOfBeds
    // •	PricePerDay
    public enum RoomType { Standard, Delux, Suit }
    public class RoomDetails
    {
        private static int s_roomID = 100;
        public string RoomID { get;  }
        public int NumberOfBeds { get; set; }
        public RoomType RoomType { get; set; }
        public double PricePerDay { get; set; }

        public RoomDetails(RoomType roomType, int numberOfBeds, double pricePerDay)
        {
            s_roomID++;
            RoomID="RID"+s_roomID;
            this.NumberOfBeds = numberOfBeds;
            this.RoomType = roomType;
            this.PricePerDay = pricePerDay;
        }
        public RoomDetails(){}
        public void ShowRoomDetails()
        {
            System.Console.WriteLine("|{0,-12}|{1,-14}|{2,-14}|{3,-13}|",RoomID,RoomType,NumberOfBeds,PricePerDay);
        }

    }
}