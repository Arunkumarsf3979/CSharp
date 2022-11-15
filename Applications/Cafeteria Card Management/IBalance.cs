namespace Cafeteria_Card_Management
{
//     Properties: WalletBalance
// Method: WalletRecharge

    public interface IBalance
    {
        public double WalletBalance { get; set; }
        public void WalletRecharge(double amount);
         
    }
}