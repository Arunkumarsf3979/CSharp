using System;
using System.IO;
using System.Collections.Generic;
namespace Question5
{
    public static class Files
    {
        private static List<string> userList=new List<string>();
        public static void Create()
        {
            if(!Directory.Exists("MetroCardManagement"))
            {
                System.Console.WriteLine("Folder not present...");
                Directory.CreateDirectory("MetroCardManagement");
                System.Console.WriteLine("Folder created Successfully..");
            }
            else
            {
                System.Console.WriteLine("Folder present...");
            }
            if(!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MetroCardManagement/UserDetails.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
        }
        public static void Read()
        {
            string []userInfo=File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach(string data in userInfo)
            {
                userList.Add(data);
            }
        }
        public static void Write()
        {
            File.WriteAllText("MetroCardManagement/UserDetails.csv","arunKumar");
            // string []userInfo=new string[userList.Count];
            // for(int i=0;i<userInfo.Length;i++)
            // {
            //     userInfo[i]=userList[i].CardNumber+','+userList[i].UserName+','+userList[i].PhoneNumber+','+userList[i].Balance;
            // }
            // File.WriteAllLines("MetroCardManagement/UserDetails.csv",userInfo);
        }
    }
}