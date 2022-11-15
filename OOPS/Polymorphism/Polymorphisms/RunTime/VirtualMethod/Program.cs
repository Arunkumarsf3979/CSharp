using System;
namespace VirtualMethod;
class Animal
{
    public virtual void Eat()
    {
        System.Console.WriteLine("Animal eat food");
    }
}
class Dog:Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Dog eat dog food");
    }
}
class Pomerian:Dog{
    public override void Eat()
    {
        System.Console.WriteLine("Pomerian eat dog food");
    }
}
class Program{
    public static void Main(string[] args)
    {
        Pomerian pomerian=new Pomerian();
        pomerian.Eat();
    }
}
