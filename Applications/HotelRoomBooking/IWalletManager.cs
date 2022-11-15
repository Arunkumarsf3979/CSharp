namespace HotelRoomBooking
{
    // Properties: WalletBalance
	// Method: WalletRecharge

    public interface IWalletManager
    {
        public double WalletBalance { get; set; }
        public void WalletRecharge(double amount);
        public void WalletDeduction(double amount);
        
    }
}