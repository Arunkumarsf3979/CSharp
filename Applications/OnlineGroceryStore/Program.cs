using System;
using System.Collections.Generic;
namespace OnlineGroceryStore;
class Program{
    public static void Main(string[] args)
    {
        // Files.Create();
        // Files.ReadToFiles();
        // // Operations.DefaultData();
        // Operations.MainMenu();
        // Files.WriteFiles();
        try{
        Operations.Starter();}
        catch(Exception e){System.Console.WriteLine(e.Message);}
    }
}
