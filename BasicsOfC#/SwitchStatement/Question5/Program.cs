using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the country among India, Pakistan, Bangladesh: ");
        String country=Console.ReadLine();
        switch(country)
        {
            case "India":
            {
                Console.WriteLine("1.Gambir");
                Console.WriteLine("2.Ashwin");
                Console.WriteLine("3.Dhoni");
                Console.WriteLine("4.Jadeja");
                break;
            }
            case "Pakistan":
            {
                Console.WriteLine("1.Aktar");
                Console.WriteLine("2.Babar Azam");
                Console.WriteLine("3.Rizwan");
                Console.WriteLine("4.Afridi");
                break;
            }
            case "Bangladesh":
            {
                Console.WriteLine("1.Shakib");
                Console.WriteLine("2.Tamim Iqbal");
                Console.WriteLine("3.Rahim");
                Console.WriteLine("4.Liton Das");
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
