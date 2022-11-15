namespace MovieTicketBooking
{
//     Properties: WalletBalance 
// Method: RechargeWallet

    public interface IWallet
    {
        public double WalletBalance { get; set; }
         
        public void RechargeWallet(double amount);
    }
}