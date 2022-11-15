using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eEEBook=new EEEDepartment("Arun","Digital Processing","Salvatores",new DateTime(2001,04,04));
        CSEDepartment cSEBook=new CSEDepartment("Ajith","Java","Salvatores",new DateTime(2001,09,09));
        System.Console.WriteLine("                       EEE Department");
        System.Console.WriteLine("                    Before Update");
        eEEBook.DisplayInfo();
        System.Console.WriteLine("                     After Update");
        eEEBook.SetBookInfo("ArunKumar","Digital Processing","Salvatores",new DateTime(2001,04,04));
        eEEBook.DisplayInfo();
        System.Console.WriteLine("                 CSE Department");
        System.Console.WriteLine("                    Before Update");
        cSEBook.DisplayInfo();
        System.Console.WriteLine("                     After Update");
        cSEBook.SetBookInfo("AjtihKumar","Java","Salvatores",new DateTime(2001,09,09));
        cSEBook.DisplayInfo();

    }
}