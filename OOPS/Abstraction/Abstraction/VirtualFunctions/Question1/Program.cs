using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator(5);
        System.Console.Write("Area    :");
        area.Calculate();
        area.display();
        VolumeCalculator volume=new VolumeCalculator(8,12);
        System.Console.Write("Volume   :");
        volume.Calculate();
        volume.display();
    }

}