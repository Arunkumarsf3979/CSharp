using System;
using System.IO;
namespace Files;
class Program{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\ArunKumarRagu\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Arun";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not present so creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else{
            System.Console.WriteLine("Directory found");
        }
        string filePath=path+"/newFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not present so creating file");
            File.Create(filePath);
        }
        else{
            System.Console.WriteLine("File found");
        }
        System.Console.WriteLine("Main menu");
        System.Console.WriteLine("1.Create folder");
        System.Console.WriteLine("2.Create file");
        System.Console.WriteLine("3.Delete folder");
        System.Console.WriteLine("4.Delete file");
        System.Console.WriteLine("5.Exit");
        System.Console.WriteLine("Enter your choice:");
        int choice =Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                Console.WriteLine("Enter the folder name you want to create");
                string name1=Console.ReadLine();
                string newPath=path+"//"+name1;
                if(!Directory.Exists(newPath))
                {
                    System.Console.WriteLine("Folder not present so creating folder");
                    Directory.CreateDirectory(newPath);
                }
                else{
                    System.Console.WriteLine("Directory already exits....");
                }
                break;
            }
            case 2:
            {
                Console.WriteLine("Enter file name you want to create");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extension you want to create ");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newPath))
                {
                    System.Console.WriteLine("File not present so creating file");
                    File.Create(newPath);
                }
                else{
                    System.Console.WriteLine("File found");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Select a folder to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                try{
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)
                        {
                            Directory.Delete(newPath);
                            Console.WriteLine("folder deleted");
                        }
                    }
                }
                catch(DirectoryNotFoundException e)
                {
                    Console.WriteLine("Directory not found",e);
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Select a file to delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter file extension you want to delete");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                try{
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)
                        {
                            File.Delete(newPath);
                            Console.WriteLine("file deleted");
                        }
                    }
                }
                catch(FileNotFoundException e)
                {
                    Console.WriteLine("file not found");
                }
                break;
            }
           
        }
        

    }
}