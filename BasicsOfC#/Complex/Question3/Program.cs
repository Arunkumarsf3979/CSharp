using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter first string: ");
        string myStr1=Console.ReadLine();
        Console.Write("enter second string: ");
        string myStr2=Console.ReadLine();
        if(myStr1.Length!=myStr2.Length)
        {
            Console.WriteLine("The given string are not anagram");
        }
        else{
            int []arr=new int[256];
            bool flag=true;
            for(int i=0;i<myStr1.Length;i++)
            {
                arr[myStr1[i]]++;
                arr[myStr2[i]]--;

            }
            foreach(int i in arr)
            {
                if(i!=0)
                {
                    flag=false;
                    Console.WriteLine("The given string are not anagram");
                }
            }
            if(flag)
            {
                Console.WriteLine("The given string are anagram");
            }
        }
    }
}
