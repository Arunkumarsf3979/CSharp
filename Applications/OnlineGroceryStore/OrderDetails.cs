namespace OnlineGroceryStore
{
//     OrderDetails Class:
// Properties: OrderID, BookingID, ProductID, PurchaseCount, PriceOfOrder

    public class OrderDetails
    {
        private static int s_orderID=100;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public float PriceOfOrder { get; set; }
        public OrderDetails(string bookingID,string productID,int purchaseCount,float priceOfOrder)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        public OrderDetails(string data)
        {
            string[]values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            ProductID=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=float.Parse(values[4]);
        }
        public void ShowOrderDetails()
        {
            System.Console.WriteLine("|{0,-9}|{1,-11}|{2,-11}|{3,-15}|{4,-14}|",OrderID,BookingID,ProductID,PurchaseCount,PriceOfOrder);
        }
    }
}