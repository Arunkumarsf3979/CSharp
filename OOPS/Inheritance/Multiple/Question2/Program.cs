using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        ShiftDezire shift1=new ShiftDezire(){TankCapacity=6,FuelType=FuelType.Petrol,BrandName="Toyoto",ModelName="suv",NoOfKmDriven=56};
        shift1.CalculateMilage();
        shift1.ShowDetails();
        ECO eco1=new ECO(){TankCapacity=6,FuelType=FuelType.Petrol,BrandName="ford",ModelName="suv",NoOfKmDriven=45};
        eco1.CalculateMilage();
        eco1.ShowDetails();

    }
}