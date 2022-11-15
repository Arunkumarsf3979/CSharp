using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Cubes cube=new Cubes(12.4);
        cube.CalculateArea();
        System.Console.WriteLine("---------------Cube-------------");
        System.Console.WriteLine("Area is "+cube.Area);
        cube.CalculateVolume();
        System.Console.WriteLine("Volume is "+cube.Volume);
        Cylinders cylinder =new Cylinders(4.5,7.8);
        System.Console.WriteLine("-------------cylinder-----------");
        cylinder.CalculateArea();
        System.Console.WriteLine("Area is "+cylinder.Area);
        cylinder.CalculateVolume();
        System.Console.WriteLine("volume is "+cylinder.Volume);
    }
}
