using System;
namespace ArunKumarTypeConversion20Oct2022;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        String name=Console.ReadLine();
        Console.Write("Enter age:");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        int mark1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        int mark2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        int mark3=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter grade: ");
        char grade=Console.ReadLine()[0];
        Console.Write("Enter mobile number: ");
        long mobileNumber=Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter Mail Id: ");
        String mailId=Console.ReadLine();
        
        // TRAINEE DETAILS 
        Console.WriteLine("Trainee Details are");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mobileNumber}");
        Console.WriteLine($"Mark1: {mark1}");
        Console.WriteLine($"Mark2: {mark2}");
        Console.WriteLine($"Mark3: {mark3}");
        int total=mark1+mark2+mark3;
        Console.WriteLine($"Total {total}");
        double average=(double)total/3;
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"MailId: {mailId}");
    }
}
