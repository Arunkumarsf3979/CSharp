namespace Question2
{
//     Class ladieswear:
// Overriden Methods: getdressinfo, Display Info -> calculate 20% discount and display the bill

    public class LadiesWear:Dress
    {
        public override DressType DressType{get;set;}
        public override string Name{get;set;}
        public override int TotalPrice{get;set;}
        public LadiesWear(string name,int totalPrice,DressType dressType)
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
            System.Console.WriteLine("FinalPrice    :"+(TotalPrice-(TotalPrice*0.20)));
        }
    }
}