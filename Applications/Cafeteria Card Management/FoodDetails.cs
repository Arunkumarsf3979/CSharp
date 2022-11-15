namespace Cafeteria_Card_Management
{
    public class FoodDetails
    {
        private static int s_foodID=100;
        /// <summary>
        /// Each fooditems has its own identity. It cannot be set by the user
        /// </summary>
        /// <value></value>
        public string FoodID{get;}
        /// <summary>
        /// It holds the name of the food
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }
        /// <summary>
        /// It holds the price of the each food
        /// </summary>
        /// <value></value>
        public double FoodPrice { get; set; }
        /// <summary>
        /// It contains availablity of stock
        /// </summary>
        /// <value></value>
        public int AvailableQuantity { get; set; }
        /// <summary>
        /// This belong to the class <see Cref="FoodDetails"/>
        /// </summary>
        /// <param name="FoodName">It holds the name of the food </param>
        /// <param name="FoodPrice">It holds the price of the each food</param>
        /// <param name="AvailableQuantity">It contains availablity of stock</param>
        public FoodDetails(string FoodName,double FoodPrice,int AvailableQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            this.FoodName=FoodName;
            this.FoodPrice=FoodPrice;
            this.AvailableQuantity=AvailableQuantity;
        }       
        ///<summary>
        /// It displays the all the properties in the class FoodDetails of current object
        /// </summary>//  
        public void ShowFoodDetails()
        {
            System.Console.WriteLine("|{0,-10}|{1,-16}|{2,-11}|{3,-19}|",FoodID,FoodName,FoodPrice,AvailableQuantity);
        }
        
        
        
    }
}