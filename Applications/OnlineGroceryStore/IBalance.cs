namespace OnlineGroceryStore
{
    // Interface IBalance
// Properties: WalletBalance
// Method: WalletRecharge

    public interface IBalance
    {
        public float WalletBalance { get; set; }
        public void WalletRecharge(float amount); 
    }
}