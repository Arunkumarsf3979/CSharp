using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        ShiftDezire shift1=new ShiftDezire(){TankCapacity=6,FuelType=FuelType.Petrol,BrandName="Toyoto",ModelName="suv",NoOfKmDriven=56};
        shift1.CalculateMilage(56,6);
        
        System.Console.WriteLine("before update");
        shift1.ShowDetails();
        System.Console.WriteLine("After Update");
        shift1.UpdateInfo(7);
        shift1.ShowDetails();
        ECO eco1=new ECO(){TankCapacity=6,FuelType=FuelType.Petrol,BrandName="ford",ModelName="suv",NoOfKmDriven=45};
        eco1.CalculateMilage(59,3);
        System.Console.WriteLine("Before update");
        eco1.ShowDetails();
        System.Console.WriteLine("AFter update");
        shift1.UpdateInfo(10);
        eco1.ShowDetails();

    }
}