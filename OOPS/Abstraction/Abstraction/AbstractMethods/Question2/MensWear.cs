namespace Question2
{
    public class MensWear:Dress
    {
        public override DressType DressType{get;set;}
        public override string Name{get;set;}
        public override int TotalPrice{get;set;}
        public MensWear(string name,int totalPrice,DressType dressType)
        {
            Name=name;
            TotalPrice=totalPrice;
            DressType=dressType;
        }
        public override void GetDressInfo()
        {
            System.Console.WriteLine("Name        :"+Name);
            System.Console.WriteLine("TotalPrice  :"+TotalPrice);
            System.Console.WriteLine("DressType   :"+DressType);
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("FinalPrice    :"+(TotalPrice-(TotalPrice*0.30)));
        }
    }
}