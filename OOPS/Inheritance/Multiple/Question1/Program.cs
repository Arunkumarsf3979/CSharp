using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson register=new RegisterPerson("Arun",Gender.Male,new DateTime(2001,04,04),78973423,872872372,MaritalDetails.Single,"Ragu","Anandhi","Chennai",1,DateTime.Today);
        System.Console.WriteLine("                     Before Update");
        register.ShowInfo();
        register.UpdateInfo("Ajith",Gender.Male,new DateTime(1998,04,04),78973423,872872372,MaritalDetails.Single,"Ragu","Anandhi","Chennai",1,DateTime.Today);
        System.Console.WriteLine("                     After Update");
        register.ShowInfo();
    }
}