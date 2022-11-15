
using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the season :");
        string season=Console.ReadLine().ToLower();
        if(season=="december" || season=="january" || season=="february")
        {
            Console.WriteLine("Winter");
        }
        else if(season=="march" || season=="april" || season=="may")
        {
            Console.WriteLine("Spring");
        }
        else if(season=="june" || season=="july" || season=="august")
        {
            Console.WriteLine("Summer");
        }
        else
        {
            Console.WriteLine("Rainfall");
        }
    }
}