using System;
using System.IO;
namespace OnlineGroceryStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineGroceryStore"))
            {
                System.Console.WriteLine("Folder is not present..");
                Directory.CreateDirectory("OnlineGroceryStore");
                System.Console.WriteLine("Folder Created Successfully.....");
            }
            else{
                System.Console.WriteLine("Folder Existing....");
            }
            if(!File.Exists("OnlineGroceryStore/BookingDetails.csv"))
            {
                System.Console.WriteLine("File is not present....");
                File.Create("OnlineGroceryStore/BookingDetails.csv");
                System.Console.WriteLine("File Created Successfully....");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
            if(!File.Exists("OnlineGroceryStore/CustomerDetails.csv"))
            {
                System.Console.WriteLine("File is not present....");
                File.Create("OnlineGroceryStore/CustomerDetails.csv");
                System.Console.WriteLine("File Created Successfully....");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
            if(!File.Exists("OnlineGroceryStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("File is not present....");
                File.Create("OnlineGroceryStore/OrderDetails.csv");
                System.Console.WriteLine("File Created Successfully....");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
            // if(!File.Exists("OnlineGroceryStore/PersonDetails.csv"))
            // {
            //     System.Console.WriteLine("File is not present....");
            //     File.Create("OnlineGroceryStore/PersonDetails.csv");
            //     System.Console.WriteLine("File Created Successfully....");
            // }
            // else{
            //     System.Console.WriteLine("File Existing...");
            // }
            if(!File.Exists("OnlineGroceryStore/ProductDetails.csv"))
            {
                System.Console.WriteLine("File is not present....");
                File.Create("OnlineGroceryStore/ProductDetails.csv");
                System.Console.WriteLine("File Created Successfully....");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
        }
        public static void WriteFiles()
        {
// string customerID,float totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus
            string []bookingInfo=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingInfo[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].CustomerID+','+Operations.bookingList[i].TotalPrice+','+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("OnlineGroceryStore/BookingDetails.csv",bookingInfo);
// tring bookingID,string productID,int purchaseCount,float priceOfOrder
            string []orderInfo=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderInfo[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].BookingID+','+Operations.orderList[i].ProductID+','+Operations.orderList[i].PurchaseCount+','+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("OnlineGroceryStore/OrderDetails.csv",orderInfo);
// string productName,int quantityAvailable,float pricePerQuantity
            string [] productInfo=new string[Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                productInfo[i]=Operations.productList[i].ProductID+','+Operations.productList[i].ProductName+','+Operations.productList[i].QuantityAvailable+','+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("OnlineGroceryStore/ProductDetails.csv",productInfo);
// string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID,float walletBalance
            string []customerInfo=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customerInfo[i]=Operations.customerList[i].CustomerID+','+Operations.customerList[i].Name+','+Operations.customerList[i].FatherName+','+Operations.customerList[i].Gender+','+Operations.customerList[i].Mobile+','+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+','+Operations.customerList[i].MailID+','+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("OnlineGroceryStore/CustomerDetails.csv",customerInfo);
        }
        public static void ReadToFiles()
        {
            string []bookingInfo=File.ReadAllLines("OnlineGroceryStore/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                BookingDetails newBooking=new BookingDetails(data);
                Operations.bookingList.Add(newBooking);
            }
            string []customerInfo=File.ReadAllLines("OnlineGroceryStore/CustomerDetails.csv");
            foreach(string data in customerInfo)
            {
                string []values=data.Split(',');
                CustomerRegistration newCustomer=new CustomerRegistration(values[1],values[2],Enum.Parse<Gender>(values[3],true),long.Parse(values[4]),DateTime.ParseExact(values[5],"dd/MM/yyyy",null),values[6]);
                newCustomer.CustomerID=values[0];
                newCustomer.WalletBalance=float.Parse(values[7]);
                Operations.customerList.Add(newCustomer);
            }
            string []orderInfo=File.ReadAllLines("OnlineGroceryStore/OrderDetails.csv");
            foreach(string data in orderInfo)
            {
                OrderDetails newOrder=new OrderDetails(data);
                Operations.orderList.Add(newOrder);
            }
            string []productInfo=File.ReadAllLines("OnlineGroceryStore/ProductDetails.csv");
            foreach(string data in productInfo)
            {
                ProductDetails newProduct=new ProductDetails(data);
                Operations.productList.Add(newProduct);
            }
        }
    }
}