using System;
using System.Collections.Generic;
namespace OnlineMedicalStore
{
    public static class Operations
    {
        private static List<UserDetails> userList=new List<UserDetails>();
        private static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        private static List<OrderDetails> orderList=new List<OrderDetails>();
        private static UserDetails currentUser;
        public static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("                             Welcome to Online Medical Store");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("1.User Registraion");
                Console.WriteLine("2.User Login");
                Console.WriteLine("3.Order History");
                Console.WriteLine("4.Exit");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.Write("Enter your choice      :");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("                             Welcome to User Registration");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                Welcome to User Login");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        LoginMenu();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                    Order History");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        ShowOrderHistory();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("                         Exited from Online Medical Store");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice Please enter again.....");
                        break;
                    }
                }
            }while(choice!=4);
        }
        private static void UserRegistration()
        {
            Console.Write("Enter your name                   :");
            string userName=Console.ReadLine();
            Console.Write("Enter your age                    :");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your city                   :");
            string city=Console.ReadLine();
            Console.Write("Enter your phone number           :");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter your balance                :");
            double balance=Convert.ToDouble(Console.ReadLine());
            UserDetails newUser=new UserDetails(userName,age,city,phoneNumber,balance);
            userList.Add(newUser);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Registration Successfully......");
            Console.WriteLine($"Your UserID {newUser.UserID} is generated.....");
        }
        private static void LoginMenu()
        {
            bool flag=true;
            Console.Write("Enter your userID      :");
            string userID=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(userID==user.UserID)
                {
                    flag=false;
                    currentUser=user;
                    char choice;
                    Console.WriteLine("Logined Successfully.......");
                    do{
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                    Welcome to Submenu");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("a.Show Medicine List");
                        Console.WriteLine("b.Purchase Medicine");
                        Console.WriteLine("c.Cancel Purchase");
                        Console.WriteLine("d.Show Purchase History");
                        Console.WriteLine("e.Recharge");
                        Console.WriteLine("f.Exit");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.Write("Enter your choice      :");
                        choice=Console.ReadLine().ToLower()[0];
                        switch(choice)
                        {
                            case 'a':
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      Medicine List");
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                ShowMedicineList();
                                break;
                            }
                            case 'b':
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                 Welcome to Purchase Medicine");
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                PurchaseMedicine();
                                break;
                            }
                            case 'c':
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                     Cancel Purchase");
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                CancelPurchase();
                                break;
                            }
                            case 'd':
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      Purchase History");
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                ShowPurchaseHistory();
                                break;
                            }
                            case 'e':
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                         Recharge");
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                                Recharge();
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Invalid choice Please enter again..........");
                                break;
                            }
                        }
                    }while(choice!='f');
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid UserID. Please enter a valid one...");
            }
        }
        private static void ShowMedicineList()
        {
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("| MedicineID | Medicine Name | Available Count | Price | Date of Expiry |");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            foreach(MedicineDetails medicine in medicineList)
            {
                Console.WriteLine("|{0,-12}|{1,-15}|{2,-17}|{3,-7}|{4,-16}|",medicine.MedicineID,medicine.MedicineName,medicine.AvailableCount,medicine.Price,medicine.DateOfExpiry.ToString("dd/MM/yyyy"));
                Console.WriteLine("|-----------------------------------------------------------------------|");
            }
        }
        private static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.Write("Enter the MedicineID to purchase    :");
            string medicineID=Console.ReadLine().ToUpper();
            Console.Write("Enter the number of medicines       :");
            int count=Convert.ToInt32(Console.ReadLine());
            bool flag=true;;
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicine.MedicineID==medicineID)
                {
                    flag=false;
                    if(medicine.AvailableCount>count)
                    {
                        if(currentUser.Balance>medicine.Price*count)
                        {
                            if(DateTime.Today<medicine.DateOfExpiry)
                            {
                                OrderDetails newOrder=new OrderDetails(currentUser.UserID,medicineID,count,medicine.Price*count,DateTime.Today,OrderStatus.Purchased);
                                medicine.AvailableCount=medicine.AvailableCount-count;
                                currentUser.Balance=currentUser.Balance-medicine.Price*count;
                                orderList.Add(newOrder);
                                Console.WriteLine("Medicine was Purchased Successfully......");
                            }
                            else{
                                Console.WriteLine("The selected medicine is expired.");
                            }
                        }
                        else{
                            Console.WriteLine("You don't have balance to purchase this medicine");
                        }
                    }
                    else{
                        Console.WriteLine("Selected medicine stock is not available.");
                    }
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid medicineID");
            }
        }
        private static void CancelPurchase()
        {
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            Console.WriteLine("| OrderID |  UserID  | MedicineId | MedicineCount | TotalPrice | OrderDate |   OrderStatus   |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            foreach(OrderDetails order in orderList)
            {
                if((order.UserID==currentUser.UserID)&&(order.OrderStatus==OrderStatus.Purchased))
                {
                    Console.WriteLine("|{0,-9}|{1,-10}|{2,-12}|{3,-15}|{4,-12}|{5,-11}|{6,-17}|",order.OrderID,order.UserID,order.MedicineID,order.MedicineCount,order.TotalPrice,order.OrderDate.ToString("dd/MM/yyyy"),order.OrderStatus);
                    Console.WriteLine("|--------------------------------------------------------------------------------------------|");
                }
            }
            Console.Write("Enter the OrderID for cancelling the purchase    :");
            string orderID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if((orderID==order.OrderID)&&(order.OrderStatus==OrderStatus.Purchased))
                {
                    flag=false;
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        if(order.MedicineID==medicine.MedicineID)
                        {
                            medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;
                        }
                    }
                    currentUser.Balance=currentUser.Balance+order.TotalPrice;
                    order.OrderStatus=OrderStatus.Cancelled;
                    Console.WriteLine("Order Cancelled successfully.............");
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid OrderId....");
            }
        }
        private static void ShowPurchaseHistory()
        {
            bool flag=true;
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            Console.WriteLine("| OrderID |  UserID  | MedicineId | MedicineCount | TotalPrice | OrderDate |   OrderStatus   |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID==currentUser.UserID)
                {
                    flag=false;
                    Console.WriteLine("|{0,-9}|{1,-10}|{2,-12}|{3,-15}|{4,-12}|{5,-11}|{6,-17}|",order.OrderID,order.UserID,order.MedicineID,order.MedicineCount,order.TotalPrice,order.OrderDate.ToString("dd/MM/yyyy"),order.OrderStatus);
                    Console.WriteLine("|--------------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                Console.WriteLine("|There is no order placed by the user                                                        |");
                Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            }
        }
        private static void Recharge()
        {
            Console.Write("Ente the amount to be recharged  :");
            double amount=Convert.ToDouble(Console.ReadLine());
            currentUser.Balance=currentUser.Balance+amount;
            Console.WriteLine("Recharged Sucessfully............");
        }
        private static void ShowOrderHistory()
        {
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            Console.WriteLine("| OrderID |  UserID  | MedicineId | MedicineCount | TotalPrice | OrderDate |   OrderStatus   |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------|");
            foreach(OrderDetails order in orderList)
            {
                
                Console.WriteLine("|{0,-9}|{1,-10}|{2,-12}|{3,-15}|{4,-12}|{5,-11}|{6,-17}|",order.OrderID,order.UserID,order.MedicineID,order.MedicineCount,order.TotalPrice,order.OrderDate.ToString("dd/MM/yyyy"),order.OrderStatus);
                Console.WriteLine("|--------------------------------------------------------------------------------------------|");
        
            }
        }
        public static void DefaultData()
        {
            UserDetails user1=new UserDetails("Ravi",33,"Theni","9877774440",400);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai","8847757470",500);
            userList.Add(user1);
            userList.Add(user2);
            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2023,06,30));
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2023,05,30));
            MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2023,04,30));
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2023,10,30));
            MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,new DateTime(2023,10,30));
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);
            medicineList.Add(medicine4);
            medicineList.Add(medicine5);
            OrderDetails order1=new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,05,13),OrderStatus.Purchased);
            OrderDetails order2=new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,05,13),OrderStatus.Cancelled);
            OrderDetails order3=new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,05,13),OrderStatus.Purchased);
            OrderDetails order4=new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,05,15),OrderStatus.Cancelled);
            OrderDetails order5=new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,05,15),OrderStatus.Purchased);
            OrderDetails order6=new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,05,15),OrderStatus.Purchased);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
        }
    }
}