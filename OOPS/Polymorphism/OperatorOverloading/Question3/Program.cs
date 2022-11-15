using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Complex complex1=new Complex(5,"10j");
        Complex complex2=new Complex(4,"12j");
        System.Console.WriteLine("Addition");
        Complex complex3=complex1+complex2;
        System.Console.WriteLine("real   :"+complex3.Real);
        System.Console.WriteLine("Imaginary :"+complex3.Imaginary);
        System.Console.WriteLine("Subtraction");
        Complex complex4=complex1-complex2;
        System.Console.WriteLine("real   :"+complex4.Real);
        System.Console.WriteLine("Imaginary :"+complex4.Imaginary);
    }
}