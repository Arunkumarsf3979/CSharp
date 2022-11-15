using System.IO;
using System;
namespace HotelRoomBooking
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("HotelRoomBooking"))
            {
                System.Console.WriteLine("Folder  not Exist");
                Directory.CreateDirectory("HotelRoomBooking");
                System.Console.WriteLine("Folder Created");
            }
            if(!File.Exists("HotelRoomBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("HotelRoomBooking/UserDetails.csv");
            }
            if(!File.Exists("HotelRoomBooking/RoomDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("HotelRoomBooking/RoomDetails.csv");
            }
            if(!File.Exists("HotelRoomBooking/RoomSelectionDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("HotelRoomBooking/RoomSelectionDetails.csv");
            }
            if(!File.Exists("HotelRoomBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("HotelRoomBooking/BookingDetails.csv");
            }
        }
        public static void Read()
        {
            string[] userInfo=File.ReadAllLines("HotelRoomBooking/UserDetails.csv");
            foreach(string data in userInfo)
            {
                string[] values=data.Split(',');
                UserRegistration newUser=new UserRegistration(values[1],long.Parse(values[2]),long.Parse(values[3]),values[4],Enum.Parse<FoodType>(values[5],true),Enum.Parse<Gender>(values[6],true),double.Parse(values[7]));
                Operations.userList.Add(newUser);
            }

            string[] bookingInfo=File.ReadAllLines("HotelRoomBooking/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                string[] values=data.Split(',');
                BookingDetails newBooking=new BookingDetails(values[1],double.Parse(values[2]),DateTime.ParseExact(values[3],"dd/MM/yyyy",null),Enum.Parse<BookingStatus>(values[4],true));
                Operations.bookingList.Add(newBooking);
            }

            string [] roomInfo=File.ReadAllLines("HotelRoomBooking/RoomDetails.csv");
            foreach(string data in roomInfo)
            {
                string[] values=data.Split(',');
                RoomDetails newRoom=new RoomDetails(Enum.Parse<RoomType>(values[1],true),int.Parse(values[2]),double.Parse(values[3]));
                Operations.roomList.Add(newRoom);
            }

            string[] selectionInfo=File.ReadAllLines("HotelRoomBooking/RoomSelectionDetails.csv");
            foreach(string data in selectionInfo)
            {
                string[] values=data.Split(',');
                RoomSelection newSelection=new RoomSelection(values[1],values[2],DateTime.ParseExact(values[3],"dd/MM/yyyy hh:mm tt",null),DateTime.ParseExact(values[4],"dd/MM/yyyy hh:mm tt",null),double.Parse(values[5]),double.Parse(values[6]),Enum.Parse<BookingStatus>(values[7],true));
                Operations.selectionList.Add(newSelection);
            }
            
        }
        public static void Write()
        {
            string []userInfo=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userInfo[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].MobileNumber+','+Operations.userList[i].AadharNumber+','+Operations.userList[i].Address+','+Operations.userList[i].FoodType+','+Operations.userList[i].Gender+','+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("HotelRoomBooking/UserDetails.csv",userInfo);

            string[] bookInfo=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookInfo[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].UserID+','+Operations.bookingList[i].TotalPrice+','+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("HotelRoomBooking/BookingDetails.csv",bookInfo);

            string[] roomInfo=new string[Operations.roomList.Count];
            for(int i=0;i<Operations.roomList.Count;i++)
            {
                roomInfo[i]=Operations.roomList[i].RoomID+','+Operations.roomList[i].RoomType+','+Operations.roomList[i].NumberOfBeds+','+Operations.roomList[i].PricePerDay;
            }
            File.WriteAllLines("HotelRoomBooking/RoomDetails.csv",roomInfo);

            string[] selectionInfo=new string[Operations.selectionList.Count];
            for(int i=0;i<Operations.selectionList.Count;i++)
            {
                selectionInfo[i]=Operations.selectionList[i].SelectionID+','+Operations.selectionList[i].BookingID+','+Operations.selectionList[i].RoomID+','+Operations.selectionList[i].StayingDateFrom.ToString("dd/MM/yyyy hh:mm tt")+','+Operations.selectionList[i].StayingDateTo.ToString("dd/MM/yyyy hh:mm tt")+','+Operations.selectionList[i].Price+','+Operations.selectionList[i].NumberOfDays+','+Operations.selectionList[i].BookingStatus;
            }
            File.WriteAllLines("HotelRoomBooking/RoomSelectionDetails.csv",selectionInfo);
        }
    }
}