using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Dog dog1=new Dog("Lab","Land","Eating Dog food");
        dog1.DisplayName();
        Duck duck1=new Duck("Duck","Water","Eating duck food");
        duck1.DisplayName();
    }
}