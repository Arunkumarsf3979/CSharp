namespace HotelRoomBooking
{
    //     •	UserName
    // •	MobileNumber
    // •	AadharNumber
    // •	Address
    // •	FoodType (Enum – Veg, NonVeg )
    // •	Gender (Enum- Male, Female, Transgender)
    public enum FoodType { Veg, NonVeg }
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalDetails
    {
        
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public long AadharNumber { get; set; }
        public string Address { get; set; }
        public FoodType FoodType { get; set; }
        public Gender Gender { get; set; }

        public PersonalDetails(string name, long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender)
        {
            this.Name = name;
            this.MobileNumber = mobileNumber;
            this.AadharNumber = aadharNumber;
            this.Address = address;
            this.FoodType = foodType;
            this.Gender = gender;

        }





    }
}