using System;
using System.Collections.Generic;
using System.IO;
namespace ReadWriteCSV;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Folder does not exists");
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("Folder created successfully");
        }
        else{
            System.Console.WriteLine("folder exist");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("File doesnot exist");
            File.Create("TestFolder/Data.csv");
            Console.WriteLine("File created successfully");
        }
        else{
            System.Console.WriteLine("File exist");
        }
        List<Student> vList=new List<Student>();
        vList.Add(new Student("stefan","salvatore",Gender.Male,new DateTime(2001,04,04)));
        vList.Add(new Student("Damon","Salvatore",Gender.Male,new DateTime(2000,09,08)));
        vList.Add(new Student("arun","ragu",Gender.Male,new DateTime(2001,04,04)));
        Insert(vList);
        Display();
    }
    static void Insert(List<Student> vList)
    {
        StreamWriter write=null;
        write=new StreamWriter(File.OpenWrite("TestFolder/Date.csv"));
        foreach(Student student in vList)
        {
            write.WriteLine(student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader reader=null;
        List<Student> listA=new List<Student>();
        if(File.Exists("TestFolder/Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("TestFolder/Data.csv"));
            while(!reader.EndOfStream)
            {
                var line=reader.ReadLine();
                var values=line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new Student(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
            }
        }
        else{
            Console.WriteLine("file doesnot exist...");
        }
        reader.Close();
        foreach(var column1 in listA)
        {
            Console.WriteLine("Your name:\t"+column1.Name+"\t Father Name :\t"+column1.FatherName+"\t Gender :\t"+column1.Gender+"\t DOB :\t"+column1.DOB.ToString("dd/MM/yyyy"));
        }
    }
}
