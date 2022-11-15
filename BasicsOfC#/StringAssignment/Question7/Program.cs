using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the  first String: ");
        String myStr1=Console.ReadLine();
        int vowels=0;
        int consonants=0;
        for(int i=0;i<myStr1.Length;i++)
        {
            if(myStr1[i]=='a'||myStr1[i]=='A'||myStr1[i]=='e'||myStr1[i]=='E'||myStr1[i]=='i'||myStr1[i]=='I'||myStr1[i]=='o'||myStr1[i]=='O'||myStr1[i]=='u'||myStr1[i]=='U')
            {
                vowels++;
            }
            else if(((int)myStr1[i]>=65 && (int)myStr1[i]<=90)||((int)myStr1[i]>=97 && (int)myStr1[i]<=122))
            {
                consonants++;
            }
        }
        Console.WriteLine("The total number of vowel in the string is : "+vowels);
        Console.WriteLine("The total number of vowel in the string is : "+consonants);
    }
}