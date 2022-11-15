using System;
using System.IO;
namespace MetroCardManagement
{
    public static class Files
    {
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
            if(!File.Exists("MetroCardManagement/TravelHistory.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MetroCardManagement/TravelHistory.csv");
                System.Console.WriteLine("File created successfully...");
            }
            else
            {
                System.Console.WriteLine("File not present");
            }
            if(!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("MetroCardManagement/TicketFairDetails.csv");
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
                UserDetails newUser=new UserDetails(data);
                Operations.userList.Add(newUser);
            }
            string []travelInfo=File.ReadAllLines("MetroCardManagement/TravelHistory.csv");
            foreach(string data in travelInfo)
            {
                TravelHistory newTravel=new TravelHistory(data);
                Operations.travelList.Add(newTravel);
            }
            string []ticketInfo=File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach(string data in ticketInfo)
            {
                TicketFairDetails newTicket=new TicketFairDetails(data);
                Operations.ticketFairList.Add(newTicket);
            }
        }
        public static void Write()
        {
            string []userInfo=new string[Operations.userList.Count];
            for(int i=0;i<userInfo.Length;i++)
            {
                userInfo[i]=Operations.userList[i].CardNumber+','+Operations.userList[i].UserName+','+Operations.userList[i].PhoneNumber+','+Operations.userList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv",userInfo);

            string[]travelInfo=new string[Operations.travelList.Count];
            for(int i=0;i<travelInfo.Length;i++)
            {
                travelInfo[i]=Operations.travelList[i].TravelID+','+Operations.travelList[i].CardNumber+','+Operations.travelList[i].FromLocation+','+Operations.travelList[i].ToLocation+','+Operations.travelList[i].Date.ToString("dd/MM/yyyy")+','+Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelHistory.csv",travelInfo);

            string[]ticketInfo=new string[Operations.ticketFairList.Count];
            for(int i=0;i<ticketInfo.Length;i++)
            {
                ticketInfo[i]=Operations.ticketFairList[i].TicketID+','+Operations.ticketFairList[i].FromLocation+','+Operations.ticketFairList[i].ToLocation+','+Operations.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv",ticketInfo);
        }
    }
}