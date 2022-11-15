using System;
namespace Question1;
public delegate string Display();
class Program{

    public static string Show()
    {
        return "Welcome to syncfusion";
    }
    public static string Message()
    {
        return "This is a product based company";
    }
    public static void Main(string[] args)
    {
        //singlecast
        Display display1=new Display(Show);
        Console.WriteLine(display1());
        
        // Multicast
        Display display2=new Display(Show);
        display2+=new Display(Message);
        Console.WriteLine(display2());

        // function delegate
        System.Console.WriteLine(FunctionDelegate.Display2(Show));
        FunctionDelegate.Display2(Message);

        //ActionDelegate
        Action<string,string> action=new Action<string, string>(ActionDelegate.Show);
        action("Arun","kumar");
    }
}