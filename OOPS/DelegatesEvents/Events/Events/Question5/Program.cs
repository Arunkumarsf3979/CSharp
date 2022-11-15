using System;
namespace Question5;
public delegate void Events();
class Program{
    public static event Events Manager;
    public static void Main(string[] args)
    {
        Manager =new Events(Files.Create);
        Manager+=new Events(Files.Read);
        Manager+=new Events(Files.Write);
        Manager();
    }
}
