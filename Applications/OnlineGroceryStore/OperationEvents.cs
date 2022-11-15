namespace OnlineGroceryStore
{
    public delegate void EventManager();
    public partial class Operations
    {
        public static event EventManager starter;
        public static event EventManager showCustomer,showProduct,walletRecharge,takeOrder,modifyOrder,cancelOrder;
        public static void Starter()
        {
            Subscribe();
            starter();
        }
        public static void Subscribe()
        {
            starter+=new EventManager(Files.Create);
            starter+=new EventManager(Files.ReadToFiles);
            starter+=new EventManager(MainMenu);
            starter+=new EventManager(Files.WriteFiles);
            showCustomer=new EventManager(ShowCustomerDetails);
            showProduct=new EventManager(ShowProductDetails);
            walletRecharge=new EventManager(WalletRecharge);
            takeOrder=new EventManager(TakeOrder);
            modifyOrder=new EventManager(ModifyOrderQuantity);
            cancelOrder=new EventManager(CancelOrder);
        }

    }
}