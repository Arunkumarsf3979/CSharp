using System;
using System.IO;
namespace ReadWriteTXT
{
    class  Program{
        public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                Console.WriteLine("Folder created");
            }
            else{
                Console.WriteLine("Folder Exits");
            }
            if(!File.Exists("TestFolder/Test.txt"))
            {
                File.Create("TestFolder/Test.txt");
                Console.WriteLine("File created");
            }
            else{
                Console.WriteLine("file found");
            }
            System.Console.WriteLine("1.Read file info");
            System.Console.WriteLine("2.Write file info");
            System.Console.WriteLine("Enter the option");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                {
                    string line;
                    StreamReader sr=null;
                    try
                    {
                        sr=new StreamReader("TestFolder/Test.txt");
                        line =sr.ReadLine();
                        // line=sr.ReadLine();
                        while(line!=null)
                        {
                            Console.WriteLine(line);
                            line=sr.ReadLine();
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine("Exception :"+e.Message);
                    }
                    finally{
                        if(sr!=null){Console.WriteLine("Executing finallh block: ");
                        sr.Close();}
                    }
                    break;
                }
                case 2:
                {
                    StreamWriter sw=null;
                    try{
                        string[] old=File.ReadAllLines("TestFolder/Test.txt");
                        sw=new StreamWriter("TestFolder/Test.txt");
                        Console.WriteLine("Enter a new content to be placed in file");
                        string info=Console.ReadLine();
                        string old1="";
                        foreach(string text in old)
                        {
                            old1=old1+"\n"+text;
                        }
                        old1=old1+"\n"+info;
                        sw.WriteLine(old1);
                    }
                    catch(Exception e){Console.WriteLine("Exception "+e.Message);}
                    finally{
                        if(sw!=null)
                        {
                            sw.Close();
                        }
                    }
                    break;
                }
            }
            
        }
    }
}
