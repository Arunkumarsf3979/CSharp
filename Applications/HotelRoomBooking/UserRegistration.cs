namespace HotelRoomBooking
{
    //     Field : _walletBalance
    // Properties:
    // a.	UserID (Auto Incremented – SF1001)
    // b.	WalletBalance
    // Method: WalletRecharge

    public class UserRegistration : PersonalDetails, IWalletManager
    {
        private static int s_userID=1000;
        private double _walletBalance=0;
        // public string Name { get; set; }
        public string UserID { get; }
        public double WalletBalance { get;set;}
        public void WalletRecharge(double amount)
        {
            WalletBalance += WalletBalance + amount;
        }
        public void WalletDeduction(double amount)
        {
            WalletBalance+=WalletBalance-amount;
        }
        public UserRegistration(string name,long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender,double walletBalance):base(name,mobileNumber, aadharNumber,address, foodType,gender)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WalletBalance = walletBalance;

        }
        public UserRegistration(string name,long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender):base(name,mobileNumber, aadharNumber,address, foodType,gender)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WalletBalance=_walletBalance;
        }
        
        public void ShowUserRegistration()
        {
            System.Console.WriteLine("|{0,-10}|{1,-16}|{2,-14}|{3,-15}|{4,-13}|{5,-10}|{6,-12}|{7,-15}|",UserID,Name,MobileNumber,AadharNumber,Address,FoodType,Gender,WalletBalance);
        }
    }
}