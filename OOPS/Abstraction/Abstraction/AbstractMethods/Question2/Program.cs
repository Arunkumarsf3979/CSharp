using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        MensWear men=new MensWear("shirt",600,DressType.Menswear);
        System.Console.WriteLine("Menswear");
        men.DisplayInfo();
        men.GetDressInfo();
        LadiesWear lady=new LadiesWear("Saree",1000,DressType.Ladieswear);
        System.Console.WriteLine("LadiesWear");
        lady.DisplayInfo();
        lady.GetDressInfo();
    }
}