using System;
namespace Cafeteria_Card_Management
{
//     	Properties:
// •	OrderID (Auto – OID1001)
// •	UserID
// •	OrderDate
// •	TotalPrice
// •	OrderStatus – (Default, Initiated, Ordered, Cancelled)
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=1000;
        /// <summary>
        /// Each order has it own identity
        /// </summary>
        /// <value></value>
        public string OrderID { get;}
        /// <summary>
        /// It belong to the class UserDetails. Each user has its own identity
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// It holds the ordered date of the product
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// It holds the total price of all ordered products in one order ID
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// It confirms whether the status of order is ordered or cancelled
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        /// <summary>
        /// This belong to the class<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="userID">It belong to the class UserDetails. Each user has its own identity</param>
        /// <param name="orderDate">It holds the ordered date of the product</param>
        /// <param name="totalPrice">It holds the total price of all ordered products in one order ID</param>
        /// <param name="orderStatus">It confirms whether the status of order is ordered or cancelled</param>
        public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
        /// <summary>
        /// It displays all the properties in the class OrderDetails of current object
        /// </summary>
        public void ShowOrderDetails()
        {
            System.Console.WriteLine("|{0,-11}|{1,-10}|{2,-13}|{3,-14}|{4,-15}|",OrderID,UserID,OrderDate.ToString("dd/MM/yyyy"),TotalPrice,OrderStatus);
        }
        
        
        
        
        
    }
}