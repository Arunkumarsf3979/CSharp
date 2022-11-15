using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Value of Radius :");
        float radius=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the choice :");
        Console.WriteLine("1.Area");
        Console.WriteLine("2.Perimeter");
        Console.WriteLine("3.Diameter");
        Console.Write("Choose the above option ");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:
            {
                Console.WriteLine($"The area is :{3.14*radius*radius}");
                break;
            }
            case 2:
            {
                Console.WriteLine($"The perimeter is :{2*3.14*radius}");
                break;
            }
            case 3:
            {
                Console.WriteLine($"The diameter is :{radius/2}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}
