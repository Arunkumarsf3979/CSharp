namespace Cafeteria_Card_Management
{
    public class CartItems
    {
        private static int s_itemID=100;
        /// <summary>
        /// It is an auto generated identity which cannot be set by the user and it is an unique identity
        /// </summary>
        /// <value></value>
        public string ItemID { get; }
        /// <summary>
        /// It belongs to the class <see cref="Orderdetails"/>. Each order has its own Identity number
        /// </summary>
        /// <value></value>
        public string OrderID { get; set; }
        /// <summary>
        /// It belongs to the class FoodDetails. Each food items has its own Identity
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }
        /// <summary>
        /// It holds the price of current product in the cart
        /// </summary>
        /// <value></value>
        public double OrderPrice { get; set; }
        /// <summary>
        /// It holds the quantity of product in the cart
        /// </summary>
        /// <value></value>
        public int OrderQuantity { get; set; }
        /// <summary>
        /// This Belong to the class <see cref="CartItems"/>
        /// </summary>
        /// <param name="OrderID">It belongs to the class <see cref="Orderdetails"/>. Each order has its own Identity number</param>
        /// <param name="FoodID">It belongs to the class FoodDetails. Each food items has its own Identity</param>
        /// <param name="OrderPrice">It holds the price of current product in the cart</param>
        /// <param name="OrderQuantity">It holds the quantity of product in the cart</param>
        public CartItems(string OrderID,string FoodID,double OrderPrice,int OrderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            this.OrderID=OrderID;
            this.FoodID=FoodID;
            this.OrderPrice=OrderPrice;
            this.OrderQuantity=OrderQuantity;
        }
        /// <summary>
        /// It displays all the properties in the class CartItems of current object
        /// </summary>
        public void ShowCartItems()
        {
            System.Console.WriteLine("|{0,-10}|{1,-11}|{2,-10}|{3,-14}|{4,-17}|",ItemID,OrderID,FoodID,OrderPrice,OrderQuantity);
        }
        
        
        
        
    }
}