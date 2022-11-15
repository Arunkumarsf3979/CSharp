using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter physics mark : ");
        float physics=Convert.ToSingle(Console.ReadLine());
        Console.Write("enter chemistry mark : ");
        float chemistry=Convert.ToSingle(Console.ReadLine());
        Console.Write("enter maths mark : ");
        float maths=Convert.ToSingle(Console.ReadLine());
        float percentage=(physics+maths+chemistry)/3;
        if(percentage>75)
        {
            Console.WriteLine("The candidate is eligible for admission");
        }
        else{
            Console.WriteLine("The candidate is not eligible for admission");
        }
    }
}