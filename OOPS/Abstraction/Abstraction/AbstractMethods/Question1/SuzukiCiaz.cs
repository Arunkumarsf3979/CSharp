namespace Question1
{
//     class SuzukiCiaz: inherit cars
// override methods: get engine type, get no. of seats, get price, get car type, Display  car detail

    public class SuzukiCiaz:Car
    {
        public SuzukiCiaz(int NoOfSeats,EngineType engineType,int price,CarType carType)
        {
            this.NoOfSeats=NoOfSeats;
            EngineType=engineType;
            Price=price;
            CarType=carType;
        }
        public override EngineType GetEngineType()
        {
            return EngineType;
        }
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override int GetPrice()
        {
            return Price;
        }
        public override CarType GetCarType()
        {
            return CarType;
        }
        public override void DisplayCarDetail()
        {
            System.Console.WriteLine("CarType         :"+CarType);
            System.Console.WriteLine("Price           :"+Price);
            System.Console.WriteLine("NoOfSeats       :"+NoOfSeats);
            ShowDoors();
            ShowWheels();

        }
    }
}