using System;
using System.IO;
namespace Cafeteria_Card_Management
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CafeteriaCardManagement"))
            {
                System.Console.WriteLine("Folder is not present");
                Directory.CreateDirectory("CafeteriaCardManagement");
                System.Console.WriteLine("Folder Created Successfully..");
            }
            else
            {
                System.Console.WriteLine("Folder Existing");
            }
            if(!File.Exists("CafeteriaCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("File is not present");
                File.Create("CafeteriaCardManagement/UserDetails.csv");
                System.Console.WriteLine("File crested Successfully..");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
            if(!File.Exists("CafeteriaCardManagement/CartItems.csv"))
            {
                System.Console.WriteLine("File is not present");
                File.Create("CafeteriaCardManagement/CartItems.csv");
                System.Console.WriteLine("File Created Successfully");
            }
            else
            {
                System.Console.WriteLine("File Existing....");
            }
            if(!File.Exists("CafeteriaCardManagement/OrderDetails.csv"))
            {
                System.Console.WriteLine("File is not present");
                File.Create("CafeteriaCardManagement/OrderDetails.csv");
                System.Console.WriteLine("File Created Successfully");
            }
            else
            {
                System.Console.WriteLine("File Existing....");
            }
            if(!File.Exists("CafeteriaCardManagement/FoodDetails.csv"))
            {
                System.Console.WriteLine("File is not present");
                File.Create("CafeteriaCardManagement/FoodDetails.csv");
                System.Console.WriteLine("File Created Successfully");
            }
            else
            {
                System.Console.WriteLine("File Existing....");
            }
        }
        public static void Read()
        {
            string[] userInfo=File.ReadAllLines("CafeteriaCardManagement/UserDetails.csv");
            foreach(string data in userInfo)
            {
                string[] values=data.Split(',');
                UserDetails user=new UserDetails(values[1],values[2],long.Parse(values[3]),values[4],Enum.Parse<Gender>(values[5],true),int.Parse(values[6].Remove(0,2)),double.Parse(values[7]));
                Operations.userList.Add(user);
            }

            string[] foodInfo=File.ReadAllLines("CafeteriaCardManagement/FoodDetails.csv");
            foreach(string data in foodInfo)
            {
                string[] values=data.Split(',');
                FoodDetails food=new FoodDetails(values[1],double.Parse(values[2]),int.Parse(values[3]));
                Operations.foodList.Add(food);
            }

            string[] cartInfo=File.ReadAllLines("CafeteriaCardManagement/CartItems.csv");
            foreach(string data in cartInfo)
            {
                string[] values=data.Split(',');
                CartItems items=new CartItems(values[1],values[2],double.Parse(values[3]),int.Parse(values[4]));
                Operations.cartList.Add(items);
            }

            string[] orderInfo=File.ReadAllLines("CafeteriaCardManagement/OrderDetails.csv");
            foreach(string data in orderInfo)
            {
                string[] values=data.Split(',');
                OrderDetails order=new OrderDetails(values[1],DateTime.ParseExact(values[2],"dd/MM/yyyy",null),double.Parse(values[3]),Enum.Parse<OrderStatus>(values[4],true));
                Operations.orderList.Add(order);
            }
        }
        public static void Write()
        {
            // UserID	UserName	FatherName	MobileNumber	MailID	Gender	WorkStationNumber	Balance
            string[] userInfo=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userInfo[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].FatherName+','+Operations.userList[i].Mobile+','+Operations.userList[i].MailID+','+Operations.userList[i].Gender+','+Operations.userList[i].WorkStationNumber+','+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("CafeteriaCardManagement/UserDetails.csv",userInfo);

            string[] foodInfo=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foodInfo[i]=Operations.foodList[i].FoodID+','+Operations.foodList[i].FoodName+','+Operations.foodList[i].FoodPrice+','+Operations.foodList[i].AvailableQuantity;
            }
            File.WriteAllLines("CafeteriaCardManagement/FoodDetails.csv",foodInfo);

            string[] orderInfo=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderInfo[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].UserID+','+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+','+Operations.orderList[i].TotalPrice+','+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("CafeteriaCardManagement/OrderDetails.csv",orderInfo);

            string[] cartInfo=new string[Operations.cartList.Count];
            for(int i=0;i<Operations.cartList.Count;i++)
            {
                cartInfo[i]=Operations.cartList[i].ItemID+','+Operations.cartList[i].OrderID+','+Operations.cartList[i].FoodID+','+Operations.cartList[i].OrderPrice+','+Operations.cartList[i].OrderQuantity;
            }
            File.WriteAllLines("CafeteriaCardManagement/CartItems.csv",cartInfo);
        }
    }
}