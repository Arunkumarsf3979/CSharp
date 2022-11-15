using System;
namespace ArrayListDS;
class Program{
    public static void Main(string[] args)
    {
        ArrayList list1=new ArrayList();
        list1.Add(100);
        list1.Add(20);
        list1.Add(3);
        list1.Add(45);
        list1.Add(50);
        list1.Sort();
        // //creating second list 
        // List<int> list2=new List<int>();
        // list2.Add(60);
        // list2.Add(70);
        // list2.Add(80);
        
        // // System.Console.WriteLine(list1.Capacity);
        // list1.AddRange(list2);
        // // for(int i=0;i<list1.Count;i++)
        // // {
        // //     System.Console.WriteLine(list1[i]);
        // // }
        System.Console.WriteLine();
        // list1.Insert(2,15);
        // list1.RemoveAt(2);
        // list1.Add(100);
        // list1.Add(110);
        foreach(int values in list1)
        {
            System.Console.WriteLine(values);
        }

        System.Console.WriteLine(list1.Count);

    }
}