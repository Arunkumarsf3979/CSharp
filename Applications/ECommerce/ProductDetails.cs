namespace ECommerce
{
    public class ProductDetails
    {
        private static int s_ProductId=100;
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int ShippingDuration { get; set; }
        public string ProductID{get;set;}

        public ProductDetails(string name,int stock,int price,int duration)
        {
            s_ProductId++;
            ProductID="PID"+s_ProductId;
            ProductName=name;
            Price=price;
            Stock=stock;
            ShippingDuration=duration;
        }
        public void RemainingStock(int count)
        {
            Stock=Stock-count;
        }

    }
}