using System;
namespace ECommerce
{
    
    public class OrderDetails
    {
        private static int s_OrderID=1000;
        public string OrderID { get; }

        public string ProductID { get;set;}
        public int TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public string OrderStatus{ get; set; }

        public string CustomerID{get;}

        public OrderDetails(int price,string productID,string customerID,DateTime date,int quantity,string status)
        {
            s_OrderID++;
            OrderID="OID"+s_OrderID;
            CustomerID=customerID;
            ProductID=productID;
            TotalPrice=price;
            PurchaseDate=date;
            Quantity=quantity;
            OrderStatus=status;
        }
    }
}