using System;
namespace DictionaryDS;
class Program{
    public static void Main(string[] args)
    {
        Dictionary<int ,string> myDict=new Dictionary<int, string>();
        myDict.Add(1,"arun");
        myDict.Add(2,"Swathi");
        myDict[3]="Arun";
        foreach(KeyValuePair<int,string> value in myDict)
        {
            System.Console.WriteLine(value.Key);
            System.Console.WriteLine(value.Value);
        }
        
    }
}
