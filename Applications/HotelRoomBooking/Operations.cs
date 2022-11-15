using System;
// using System.Collections.Generic;
namespace HotelRoomBooking
{
    public static partial class Operations
    {
        public static List<UserRegistration> userList=new List<UserRegistration>();
        public static List<RoomDetails> roomList=new List<RoomDetails>();
        public static List<RoomSelection> selectionList=new List<RoomSelection>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static UserRegistration currentUser;
        public static void DefaultData()
        {
            UserRegistration user1=new UserRegistration("Ravichandran",995875777,347777378383,"Chennai",FoodType.Veg,Gender.Male,5000);
            UserRegistration user2=new UserRegistration("Baskaran",448844848,474777477477,"Chennai",FoodType.NonVeg,Gender.Male,6000);
            userList.Add(user1);
            userList.Add(user2);
            foreach(UserRegistration user in userList)
            {
                user.ShowUserRegistration();
            }
            RoomDetails room1=new RoomDetails(RoomType.Standard,2,500);
            RoomDetails room2=new RoomDetails(RoomType.Standard,4,700);
            roomList.Add(room1);
            roomList.Add(room2);
            foreach(RoomDetails room in roomList)
            {
                room.ShowRoomDetails();
            }
            RoomSelection selection1=new RoomSelection("BID101","RID101",new DateTime(2022,11,11,06,00,00,DateTimeKind.Utc)	,new DateTime(2022,12,11,02,00,00,DateTimeKind.Utc),750,1.5,BookingStatus.Booked);
            selectionList.Add(selection1);
            foreach(RoomSelection selection in selectionList)
            {
                selection.ShowRoomSelectionList();
            }
            BookingDetails booking1=new BookingDetails("SF1001",1450,new DateTime(2022,11,10),BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("SF1002",2000,new DateTime(2022,11,10),BookingStatus.Cancelled);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            foreach(BookingDetails booking in bookingList)
            {
                booking.ShowBookingDetails();
            }
        }
        public static void MainMenu()
        {
            int choice;
            do{
                System.Console.WriteLine("Welcome to AK Hotel");
                System.Console.WriteLine("1.New User Registration");
                System.Console.WriteLine("2.User Login");
                System.Console.WriteLine("3.Exit");
                System.Console.Write("Enter your choice      :");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("New Registration");
                        NewRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Welcome To Login Menu");
                        LoginMenu();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exited from the application");
                        break;
                    }
                }
            }while(choice!=3);
        }
//         a.	User Name
// b.	Mobile Number
// c.	Aadhar Number
// d.	Address
// e.	Food type
// f.	Gender
// g.	WalletBalance

        private static void NewRegistration()
        {
            bool temp;
            System.Console.WriteLine("Enter Your Name                   :");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your Mobile Number          :");
            long mobile;
            temp=long.TryParse(Console.ReadLine(),out mobile);
            while (!temp)
            {
                System.Console.WriteLine("Invalid Input...Please Enter again...");
                System.Console.WriteLine("Enter Your Mobile Number           :");
                temp=long.TryParse(Console.ReadLine(),out mobile);
            }
            long aadharNumber;
            System.Console.WriteLine("Enter Your Aadhar Number           :");
            temp=long.TryParse(Console.ReadLine(),out aadharNumber);
            while (!temp)
            {
                System.Console.WriteLine("Invalid Input...Please Enter again...");
                System.Console.WriteLine("Enter Your Aadhar Number           :");
                temp=long.TryParse(Console.ReadLine(),out aadharNumber);
            }
            System.Console.WriteLine("Enter Your Address                     :");
            string address=Console.ReadLine();
            System.Console.WriteLine("Enter Your FoodType                    :");
            FoodType foodType;
            temp=Enum.TryParse<FoodType>(Console.ReadLine(),true,out foodType);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input...Please Enter again...");
                System.Console.WriteLine("Enter Your FoodType                    :");
                temp=Enum.TryParse<FoodType>(Console.ReadLine(),true,out foodType);
            }
            System.Console.WriteLine("Enter Your Gender                      :");
            Gender gender;
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input...Please Enter again...");
                System.Console.WriteLine("Enter Your Gender                      :");
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            UserRegistration newUser=new UserRegistration(name,mobile,aadharNumber,address,foodType,gender);
            userList.Add(newUser);
            System.Console.WriteLine("Your Generated UserID is "+newUser.UserID);
        }
        private static void LoginMenu()
        {
            bool flag=true;
            System.Console.WriteLine("Enter Your UserID");
            string UserID=Console.ReadLine().ToUpper();
            foreach(UserRegistration user in userList)
            {
                if(user.UserID.Equals(UserID))
                {
                    flag=false;
                    currentUser=user;
                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("User Not Found");
            }
        }
//         a.	View Customer Profile
// b.	Book Room
// c.	Cancel Booking
// d.	Booking History
// e.	Exit 

        private static void SubMenu()
        {
            char choice;
            do{
                System.Console.WriteLine("Welcome "+currentUser.Name);
                System.Console.WriteLine("a.View Customer Profile");
                System.Console.WriteLine("b.Book Room");
                System.Console.WriteLine("c.Cancel Booking");
                System.Console.WriteLine("d.Booking History");
                System.Console.WriteLine("e.Recharge Wallet");
                System.Console.WriteLine("f.Exit");
                System.Console.WriteLine("Enter Your Choice      :");
                choice=Console.ReadLine().ToLower()[0];
                switch(choice)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Hi "+currentUser.Name);
                        ViewCustomerProfile();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("");
                        BookRoom();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Cancel Booking");
                        CancelBooking();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Booking History");
                        BookingHistory();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Recharge Wallet");
                        RechargeWallet();
                        break;
                    }
                    case 'f':
                    {
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }while(choice!='f');
        }
        private static void ViewCustomerProfile()
        {
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|  UserID  |    UserName    | MobileNumber | Aadhar Number |   Address   | FoodType |   Gender   | WalletBalance |");
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            currentUser.ShowUserRegistration();
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");

        }
        // 1.Create Booking Obj status-Initiated
        // 2.Temp room List
        // 3.List the available rooms
        // 4.User input
        // 5.check the room whether it is booked or not 
        // 6.create selection List
        // 7.add to temproom list
        // 8.ask do you want to continue if yes step 4 to step 7
        // 9.no - calculate amount  update in booking obj
        // 10.check balance -enough balance book it or no balance recharge it
        // 11.show bookingID
        private static void BookRoom()
        {
            bool flag=true;
            BookingDetails booking=new BookingDetails(currentUser.UserID,0,DateTime.Now,BookingStatus.Initiated);
            List<RoomSelection> tempSelectionList=new List<RoomSelection>();
            RoomDetails selectedRoom=new RoomDetails();
            string choice="";
            do{
                System.Console.WriteLine("|--------------------------------------------------------|");
                System.Console.WriteLine("|   RoomId   |   RoomType   | NumberOfBeds | PricePerDay |");
                System.Console.WriteLine("|--------------------------------------------------------|");
                foreach(RoomDetails room in roomList)
                {
                    room.ShowRoomDetails();
                }
                System.Console.WriteLine("|--------------------------------------------------------|");
                bool temp;
                System.Console.WriteLine("Enter the CheckIn date      :");
                DateTime chechIn;
                temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm tt",null,System.Globalization.DateTimeStyles.None,out chechIn);
                while(!temp)
                {
                    System.Console.WriteLine("Invalid CheckIn date......Please Enter Again...");
                    System.Console.WriteLine("Enter the CheckIn date      :");
                    temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm tt",null,System.Globalization.DateTimeStyles.None,out chechIn);
                }
                System.Console.WriteLine("Enter the CheckOut date     :");
                DateTime chechOut;
                temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm tt",null,System.Globalization.DateTimeStyles.None,out chechOut);
                while(!temp)
                {
                    System.Console.WriteLine("Invalid CheckOut date......Please Enter Again...");
                    System.Console.WriteLine("Enter the CheckOut date      :");
                    temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm tt",null,System.Globalization.DateTimeStyles.None,out chechOut);
                }
                room:
                System.Console.WriteLine("Enter the Room Id            :");
                string roomID=Console.ReadLine().ToUpper();
                TimeSpan timeSpent=chechOut.Subtract(chechIn);
                double noOfDays=timeSpent.Days;
                foreach(RoomDetails room in roomList)
                {
                    if(room.RoomID.Equals(roomID))
                    {
                        flag=false;
                        selectedRoom=room;
                    }
                    
                }
                if(flag)
                {
                    System.Console.WriteLine("Invalid RoomID....");
                    flag=true;
                    goto room;
                }
                flag=true;
                foreach(RoomSelection selection in selectionList)
                {
                    if(selection.RoomID.Equals(roomID))
                    {
                        flag=false;
                        if((selection.BookingStatus.Equals(BookingStatus.Booked)&&(selection.StayingDateFrom>chechIn && selection.StayingDateFrom>chechOut))||(!selection.BookingStatus.Equals(BookingStatus.Booked)))
                        {
                            RoomSelection select=new RoomSelection(booking.BookingID,roomID,chechIn,chechOut,noOfDays*selectedRoom.PricePerDay,noOfDays,BookingStatus.Booked);
                            tempSelectionList.Add(select);
                            System.Console.WriteLine("Do you want to select another room   :");
                            choice=Console.ReadLine().ToLower();
                        }
                        else
                        {
                            System.Console.WriteLine("Selected Room is Booked Already...");
                            System.Console.WriteLine("Do you want to select another room   :");
                            choice=Console.ReadLine().ToLower();
                        }
                    }  
                }
                if(flag)
                {
                    RoomSelection select=new RoomSelection(booking.BookingID,roomID,chechIn,chechOut,noOfDays*selectedRoom.PricePerDay,noOfDays,BookingStatus.Booked);
                    tempSelectionList.Add(select);
                    System.Console.WriteLine("Do you want to select another room   :");
                    choice=Console.ReadLine().ToLower();
                }
                
            }while(choice=="yes");
            do
            {
                double totalRent=0;
                foreach(RoomSelection rooms in tempSelectionList)
                {
                    totalRent+=rooms.Price;
                }
                if(totalRent<currentUser.WalletBalance)
                {
                    booking.BookingStatus=BookingStatus.Booked;
                    currentUser.WalletDeduction(totalRent);
                    booking.TotalPrice=totalRent;
                    System.Console.WriteLine("Your BookingId is "+booking.BookingID);
                    bookingList.Add(booking);
                    selectionList.AddRange(tempSelectionList);
                    return;
                }
                else
                {
                    System.Console.WriteLine("Insufficient balance");
                    System.Console.WriteLine("Do you want to recharge your wallet");
                    choice=Console.ReadLine().ToLower();
                    if(choice=="yes")
                    {
                        System.Console.WriteLine("Enter the amount to be recharged    :");
                        double amount=double.Parse(Console.ReadLine());
                        currentUser.WalletRecharge(amount);
                        System.Console.WriteLine("Recharged Successfully...");
                    }
                    else{
                        System.Console.WriteLine("Payment cancelled..");
                    }
                }
            }while(choice=="yes");
            System.Console.WriteLine("Existing without booking rooms.....");
        }
        // 1.show customer booking history(booked)
        // 2.user input (booking id) validate id
        // 3.if yes (change booking status to cancelled)
        // 4.return booking amount to user
        // 5.Selection list (BookingStatus to cancelled)
        private static void CancelBooking()
        {
            bool flag=true;
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|   BookingID   |    UserID    |   TotalPrice   |     DateOfBooking     |   BookingStatus   |");
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID.Equals(booking.UserID)&&booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            if(flag)
            {
                System.Console.WriteLine("There is no booking from the user....");
                flag=true;
            }
            System.Console.WriteLine("Enter the bookingID to be cancelled    :");
            string bookingID=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                if(bookingID.Equals(booking.BookingID))
                {
                    flag=false;
                    System.Console.WriteLine("Do you want to cancel your booking     :");
                    string choice=Console.ReadLine().ToLower();
                    if(choice=="yes")
                    {
                        booking.BookingStatus=BookingStatus.Cancelled;
                        currentUser.WalletBalance+=booking.TotalPrice;
                        System.Console.WriteLine("Booking Cancelled successfully....");
                    }
                    else{
                        System.Console.WriteLine("Exited without cancelling..");
                        return;
                    }
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid User Input....");
            }
            foreach(RoomSelection roomSelect in selectionList)
            {
                if(roomSelect.BookingID.Equals(bookingID))
                {
                    roomSelect.BookingStatus=BookingStatus.Cancelled;
                }
            }
        }
        private static void BookingHistory()
        {
            bool flag=true;
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|   BookingID   |    UserID    |   TotalPrice   |     DateOfBooking     |   BookingStatus   |");
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID.Equals(booking.UserID))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------|");

            if(flag)
            {
                System.Console.WriteLine("There is no booking from the user....");
                flag=true;
                return;  
            }
            System.Console.WriteLine("Enter the bookingID     :");
            string bookingID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|  SelectionID  |  BookingID  |  RoomID  |     StayingDateFrom     |     StayingDateTo     |  Price  |  NumberOfDays  |  BookingStatus  |");
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------|");
            foreach(RoomSelection roomSelect in selectionList)
            {
                if(roomSelect.BookingID.Equals(bookingID))
                {
                    flag=false;
                    roomSelect.ShowRoomSelectionList();
                }
            }
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------|");
            if(flag)
            {
                System.Console.WriteLine("Invalid Input.....");
            }
        }
        private static void RechargeWallet()
        {
            System.Console.WriteLine("Enter the amount to be Recharged   :");
            double amount=double.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
            System.Console.WriteLine("Recharged Successfully...");
        }
    }
}