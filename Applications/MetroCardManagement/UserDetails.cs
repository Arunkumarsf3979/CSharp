namespace MetroCardManagement
{
//     •	CardNumber(Auto generation- CMRL101)
// •	UserName
// •	Phone Number
// •	Balance

    public class UserDetails
    {
        private static int s_cardNumber=100;
        public string CardNumber { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int Balance { get; set; }
        
        public UserDetails(string UserName,string PhoneNumber)
        {
            s_cardNumber++;
            CardNumber="CMRL"+s_cardNumber;
            this.UserName=UserName;
            this.PhoneNumber=PhoneNumber;
        }
        public UserDetails(string UserName,string PhoneNumber,int Balance)
        {
            s_cardNumber++;
            CardNumber="CMRL"+s_cardNumber;
            this.UserName=UserName;
            this.PhoneNumber=PhoneNumber;
            this.Balance=Balance;
        }
        public UserDetails(string data)
        {
            string []values=data.Split(',');
            s_cardNumber=int.Parse(values[0].Remove(0,4));
            CardNumber=values[0];
            UserName=values[1];
            PhoneNumber=values[2];
            Balance=int.Parse(values[3]);
        }
    }
}