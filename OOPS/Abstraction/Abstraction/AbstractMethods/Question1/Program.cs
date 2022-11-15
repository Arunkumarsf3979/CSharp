using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        MarutiSwift maruti=new MarutiSwift(6,EngineType.Petrol,12000000,CarType.hatchback);
        System.Console.WriteLine("Maruti");
        maruti.GetCarType();
        maruti.GetEngineType();
        maruti.GetNoOfSeats();
        maruti.GetPrice();
        maruti.DisplayCarDetail();
        System.Console.WriteLine("Suzuki");
        SuzukiCiaz suzuki=new SuzukiCiaz(4,EngineType.Diesel,78339090,CarType.Sedan);
        System.Console.WriteLine("Suzuki");
        suzuki.GetCarType();
        suzuki.GetEngineType();
        suzuki.GetNoOfSeats();
        suzuki.GetPrice();
        suzuki.DisplayCarDetail();
    }
}