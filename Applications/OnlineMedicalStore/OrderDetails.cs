using System;
namespace OnlineMedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=2000;
        public string OrderID { get; }
        /// <summary>
        /// unique id for every orders
        /// </summary>
        /// <value></value>
        public string  UserID { get; set; }
        /// <summary>
        /// unique id for the medcineid
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// count placed for ordering items
        /// </summary>
        /// <value></value>
        public int MedicineCount { get; set; }
        /// <summary>
        /// total price of ordered items
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// ordered placed on date
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// order status of ordered item
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        /// <summary>
        /// details of ordering items
        /// </summary>
        /// <param name="userID">unique id of user is auto generated</param>
        /// <param name="medicineID">every medicine has unique id</param>
        /// <param name="medicineCount">count for purchasing the medicine</param>
        /// <param name="totalPrice">total price of all items</param>
        /// <param name="orderDate">order placed on date</param>
        /// <param name="orderStatus">order status of purchased items</param>
        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }
    }
}