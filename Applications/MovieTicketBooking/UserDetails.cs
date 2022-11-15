namespace MovieTicketBooking
{
//     3.	UserDetails: inherit PersonalDetails, IWallet
// Properties:
// •	UserID (Auto Increment - UID1001)

    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID=1000;
        public string UserID { get; }
        public double WalletBalance { get; set; }
        
        
        public UserDetails(string name,int age,long phoneNumber,double walletBalance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
            WalletBalance=WalletBalance;
        }
        public void RechargeWallet(double amount)
        {
            WalletBalance+=amount;
        }
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);

        }
        
    }
}