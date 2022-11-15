using System;
using System.Collections.Generic;
namespace OnlineGroceryStore
{
    public partial class Operations
    {
        public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        private static CustomerRegistration currentCustomer;
        public static void MainMenu()
        {
            System.Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                        Welcome to online grocery store");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            int choice=0;
            bool flag;
            do
            {
                Console.WriteLine("1.Customer Registration");
                Console.WriteLine("2.Customer Login");
                Console.WriteLine("3.Exit");
                System.Console.WriteLine("---------------------------------------------------------------------------"); 
                Console.Write("Enter your choice :");
                flag=int.TryParse(Console.ReadLine(),out choice);
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                       Welcome to Registation");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        Registation();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                        Welcome to Login");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        Console.ForegroundColor=ConsoleColor.Green;
                        System.Console.WriteLine("                     Exited from the application");
                        Console.ResetColor();
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        break;
                    }
                    default:
                    {
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        System.Console.WriteLine("Invalid input. Please enter again.");
                        Console.ResetColor();
                        break;
                    }
                }
            } while ((choice!=3)||(!flag));
        }
        private static void Registation()
        {
            try
            {
                bool temp;
                System.Console.Write("Enter Your Name              :");
                string name=Console.ReadLine();
                System.Console.Write("Enter Your Father Name       :");
                string fatherName=Console.ReadLine();
                System.Console.Write("Enter Your Gender            :");
                Gender gender;
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                while(!temp)
                {
                    System.Console.Write("Invalid Input. Enter Your Gender            :");
                    temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                }
                System.Console.Write("Enter Your Mobile Number     :");
                long mobile;
                temp=long.TryParse(Console.ReadLine(),out mobile);
                while(!temp)
                {
                    System.Console.Write("Invalid Input.Enter Your Mobile Number     :");
                    temp=long.TryParse(Console.ReadLine(),out mobile);
                }
                System.Console.Write("Enter Your Date Of Birth     :");
                DateTime dob;
                temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
                while(!temp)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    System.Console.WriteLine("Invalid input....");
                    Console.ResetColor();
                    System.Console.Write("Enter Your Date Of Birth     :");
                    temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
                }
                System.Console.Write("Enter Your MailID            :");
                string mailID=Console.ReadLine();
                CustomerRegistration newCustomer=new CustomerRegistration(name,fatherName,gender,mobile,dob,mailID);
                customerList.Add(newCustomer);
                Console.ForegroundColor=ConsoleColor.Green;
                System.Console.WriteLine("Your CustomerID is "+newCustomer.CustomerID);
                Console.ResetColor();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        private static void Login()
        {
            bool flag=true;
            System.Console.Write("Enter Your Customer ID         :");
            string customerID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("---------------------------------------------------------------------------");
            foreach(CustomerRegistration customer in customerList)
            {
                if(customer.CustomerID.Equals(customerID))
                {
                    currentCustomer=customer;
                    flag=false;
                    SubMenu();
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                System.Console.WriteLine("CustomerID is Invalid.....");
                Console.ResetColor();
            }
        }
        private static void SubMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("a.Show Customer Details");
                System.Console.WriteLine("b.Show Product Details");
                System.Console.WriteLine("c.Wallet Recharge");
                System.Console.WriteLine("d.Take Order");
                System.Console.WriteLine("e.Modify Order Quantity");
                System.Console.WriteLine("f.Cancel Order");
                System.Console.WriteLine("g.Exit");
                System.Console.WriteLine("---------------------------------------------------------------------------");
                System.Console.Write("Enter your choice   :");
                choice =Console.ReadLine().ToLower()[0];
                switch(choice)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                               Your Profile");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        ShowCustomerDetails();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                             Product Details");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        ShowProductDetails();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                            Wallet Recharge");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        WalletRecharge();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                         Take Your Order");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        TakeOrder();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                     Modify Your Order Qunatity");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        ModifyOrderQuantity();
                        break;
                    }
                    case 'f':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("                          Cancel Order");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        CancelOrder();
                        break;
                    }
                    case 'g':
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        break;
                    }
                    default:
                    {
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        System.Console.WriteLine("Invalid Input.Enter again.");
                        Console.ResetColor();
                        break;
                    }
                }
            }while(choice!='g');

        }
        private static void ShowCustomerDetails()
        {
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| CustomerID |        Name        |     FatherName     | Gender |   Mobile   | DateOfBirth |          MailID          |  Balance  |");
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------|");
            foreach(CustomerRegistration customer in customerList)
            {
                if(currentCustomer.CustomerID==customer.CustomerID)
                {
                    System.Console.WriteLine("|{0,-12}|{1,-20}|{2,-20}|{3,-8}|{4,-12}|{5,-13}|{6,-26}|{7,-11}|",customer.CustomerID,customer.Name,customer.FatherName,customer.Gender,customer.Mobile,customer.DOB.ToString("dd/MM/yyyy"),customer.MailID,customer.WalletBalance);
                }
            }
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------|");

        }
        private static void ShowProductDetails()
        {
            System.Console.WriteLine("|---------------------------------------------------------------------------|");
            System.Console.WriteLine("| ProductID |     ProductName     |  QuantityAvailable |  PricePerQuantity  |");
            System.Console.WriteLine("|---------------------------------------------------------------------------|");
            foreach(ProductDetails product in productList)
            {
                product.ShowProductDetails();
            }
            System.Console.WriteLine("|---------------------------------------------------------------------------|");
        }
        private static void TakeOrder()
        {
            string choice;
            float totalPurchaseAmount=0;
            BookingDetails newBooking=new BookingDetails();
            List<OrderDetails> tempOrderList=new List<OrderDetails>();
            System.Console.Write("Do You Want To Purchase Yes or No  :");
            choice=Console.ReadLine().ToLower();
            if(choice=="yes")
            {
                newBooking=new BookingDetails(currentCustomer.CustomerID,0,DateTime.Today,BookingStatus.Initiated);
            }
            while(choice=="yes")
            {
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.WriteLine("| ProductID |     ProductName     |  QuantityAvailable |  PricePerQuantity  |");
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                foreach(ProductDetails product in productList)
                {
                    if(product.QuantityAvailable>0)
                    {
                        product.ShowProductDetails();
                    }
                }
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.Write("Enter The ProductId To Purchase Your Product :");
                string productId=Console.ReadLine().ToUpper();
                bool flag=true;
                foreach(ProductDetails product in productList)
                {
                    if(product.ProductID==productId)
                    {
                        flag=false;
                        System.Console.Write("Enter The Qunatity You Would Like to Purchase :");
                        int quantity=Convert.ToInt32(Console.ReadLine());
                        if(product.QuantityAvailable>=quantity)
                        {
                            OrderDetails newOrder=new OrderDetails(newBooking.BookingID,productId,quantity,quantity*product.PricePerQuantity);
                            tempOrderList.Add(newOrder);
                            product.QuantityAvailable=product.QuantityAvailable-quantity;
                            totalPurchaseAmount=totalPurchaseAmount+quantity*product.PricePerQuantity;
                            Console.ForegroundColor=ConsoleColor.Green;
                            System.Console.WriteLine("Produt Successfully Added To The Cart");
                            Console.ResetColor();
                        }
                        else{
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            System.Console.WriteLine("Stock Unavailable....");
                            Console.ResetColor();
                        }
                    }
                }
                if(flag)
                {
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    System.Console.WriteLine("Invalid ProductID.....");
                    Console.ResetColor();
                    return;
                }
                System.Console.Write("Do You Want To Purchase Yes or No  :");
                choice=Console.ReadLine().ToLower();
            }
            do
            {
                System.Console.Write("Do You Want To Confirm Your Order Yes or No  :");
                choice=Console.ReadLine().ToLower();
                if(choice=="yes")
                {
                    if(currentCustomer.WalletBalance>totalPurchaseAmount)
                    {
                        currentCustomer.WalletBalance-=totalPurchaseAmount;
                        newBooking.TotalPrice=totalPurchaseAmount;
                        newBooking.BookingStatus=BookingStatus.Booked;
                        orderList.AddRange(tempOrderList);
                        Console.ForegroundColor=ConsoleColor.Green;
                        System.Console.WriteLine("Order Placed Successfully....");
                        Console.ResetColor();
                        bookingList.Add(newBooking);
                        return;
                    }
                    else{
                        do{
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            System.Console.WriteLine("Insufficient Account Balance...");
                            Console.ResetColor();
                            WalletRecharge();
                        }while(currentCustomer.WalletBalance<totalPurchaseAmount);
                    }
                }
            }while(choice=="yes");
            foreach(OrderDetails order in tempOrderList)
            {
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID==product.ProductID)
                    {
                        product.QuantityAvailable+=order.PurchaseCount;
                    }
                }
            }
        }
        private static void WalletRecharge()
        {
            try{    
                System.Console.Write("Enter the amount to be recharged  :");
                float amount=Convert.ToSingle(Console.ReadLine());
                currentCustomer.WalletRecharge(amount);
                Console.ForegroundColor=ConsoleColor.Green;
                System.Console.WriteLine("Wallet Recharged Successfully...");
                Console.ResetColor();
            }
            catch(Exception e){System.Console.WriteLine(e.Message);}
        }
        private static void CancelOrder()
        {
            bool flag=true;
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("| BookingID | CustomerID | TotalPrice | DateOfBooking | BookingStatus |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID==currentCustomer.CustomerID)&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                System.Console.WriteLine("There is no booking by the customer...");
                Console.ResetColor();
                return;
            }
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.Write("Enter Your BookingID To Cancel Your Booking  :");
            string bookingID=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.BookingID==bookingID)&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    flag=false;
                    booking.BookingStatus=BookingStatus.Cancelled;
                    currentCustomer.WalletBalance+=booking.TotalPrice;
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingID==order.BookingID)
                        {
                            foreach(ProductDetails product in productList)
                            {
                                if(order.ProductID==product.ProductID)
                                {
                                    product.QuantityAvailable+=order.PurchaseCount;
                                }
                            }
                        }
                    }
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine("Booking Cancelled Successfully....");
                    Console.ResetColor();
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                System.Console.WriteLine("Invalid BookingID...");
                Console.ResetColor();
            }
        }
        private static void ModifyOrderQuantity()
        {
            bool flag=true;
            BookingDetails userBooking=new BookingDetails();
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("| BookingID | CustomerID | TotalPrice | DateOfBooking | BookingStatus |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID==currentCustomer.CustomerID)&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                System.Console.WriteLine("There is no booking by the customer...");
                Console.ResetColor();
                flag=true;
                return;
            }
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("                           Your Order");
            System.Console.WriteLine("|----------------------------------------------------------------|");
            System.Console.WriteLine("| OrderID | BookingID | ProductId | PurchaseCount | PriceOfOrder |");
            System.Console.WriteLine("|----------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID==currentCustomer.CustomerID)&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    userBooking=booking;
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingID==order.BookingID)
                        {
                            order.ShowOrderDetails();
                        }
                    }
                }
            }
            System.Console.WriteLine("|----------------------------------------------------------------|");
            System.Console.Write("Enter The OrderID To Modify Your Order   :");
            string orderID=Console.ReadLine().ToUpper();
            flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(orderID==order.OrderID)
                {
                    flag=false;
                    foreach(ProductDetails product in productList)
                    {
                        if(order.ProductID==product.ProductID)
                        {
                            System.Console.Write("Enter The New Quantity For The Product  :");
                            int quantity=Convert.ToInt32(Console.ReadLine());
                            if((quantity-order.PurchaseCount)<=product.QuantityAvailable)
                            {
                                userBooking.TotalPrice-=order.PriceOfOrder;
                                product.QuantityAvailable=product.QuantityAvailable+(order.PurchaseCount-quantity);
                                order.PurchaseCount=quantity;
                                order.PriceOfOrder=quantity*product.PricePerQuantity;
                                userBooking.TotalPrice+=quantity*product.PricePerQuantity;
                                Console.ForegroundColor=ConsoleColor.Green;
                                System.Console.WriteLine("Modified Successfully...");
                                Console.ResetColor();
                            }
                            else{
                                Console.ForegroundColor=ConsoleColor.DarkRed;
                                System.Console.WriteLine("Stock is not available...");
                                Console.ResetColor();
                                return;
                            }
                        }
                    }
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                System.Console.WriteLine("Invalid OrderID...");
                Console.ResetColor();
            }
        }
        public static void DefaultData()
        {
            CustomerRegistration customer1=new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com",10000);
            CustomerRegistration customer2=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com",15000);
            customerList.Add(customer1);
            customerList.Add(customer2);
            ProductDetails product1=new ProductDetails("Sugar",20,40);
            ProductDetails product2=new ProductDetails("Rice",100,50);
            ProductDetails product3=new ProductDetails("Milk",10,40);
            ProductDetails product4=new ProductDetails("Coffee",10,10);
            ProductDetails product5=new ProductDetails("Tea",10,10);
            ProductDetails product6=new ProductDetails("Masala Powder",10,20);
            ProductDetails product7=new ProductDetails("Salt",10,10);
            ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
            ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
            ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);
            BookingDetails booking1=new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking3=new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
            BookingDetails booking4=new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);
            OrderDetails order1=new OrderDetails("BID3001","PID101",2,80);
            OrderDetails order2=new OrderDetails("BID3001","PID102",2,100);
            OrderDetails order3=new OrderDetails("BID3001","PID103",1,40);
            OrderDetails order4=new OrderDetails("BID3002","PID101",1,40);
            OrderDetails order5=new OrderDetails("BID3002","PID102",4,200);
            OrderDetails order6=new OrderDetails("BID3002","PID110",1,140);
            OrderDetails order7=new OrderDetails("BID3002","PID109",1,20);
            OrderDetails order8=new OrderDetails("BID3003","PID102",2,100);
            OrderDetails order9=new OrderDetails("BID3003","PID108",4,100);
            OrderDetails order10=new OrderDetails("BID3003","PID101",2,80);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3); 
            orderList.Add(order4); 
            orderList.Add(order5); 
            orderList.Add(order6);
            orderList.Add(order7);
            orderList.Add(order8); 
            orderList.Add(order9); 
            orderList.Add(order10); 
        }
    }
}
