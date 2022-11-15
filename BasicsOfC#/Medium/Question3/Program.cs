using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the  length of a side of the ground: ");
        double length=Convert.ToDouble(Console.ReadLine());
        Console.Write("enter the width of tile: ");
        double widthOfTile=Convert.ToDouble(Console.ReadLine());
        Console.Write("enter the  length of tile: ");
        double lengthOfTile=Convert.ToDouble(Console.ReadLine());
        Console.Write("enter the width of bench: ");
        double widthOfBench=Convert.ToDouble(Console.ReadLine());
        Console.Write("enter the length of bench: ");
        double lengthOfBench=Convert.ToDouble(Console.ReadLine());
        double areaOfGround=length*length;
        double areaOftile=lengthOfTile*widthOfTile;
        double areaOfBench=lengthOfBench*widthOfBench;
        double tile=(areaOfGround-areaOfBench)/areaOftile;
        Console.WriteLine("Number of tiles needed: "+tile);
        Console.WriteLine("Time required to change the tile: "+(tile*0.2));

    }
}