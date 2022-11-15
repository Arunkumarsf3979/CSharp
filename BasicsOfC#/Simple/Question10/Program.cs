using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the character: ");
        char vowel=Console.ReadLine().ToLower()[0];
        if(vowel=='a'|| vowel=='e'|| vowel=='i'|| vowel=='o'|| vowel=='u')
        {
            Console.Write("It is a vowel");
        }
        else{
            Console.WriteLine("It is not a vowel");
        }
    }
}