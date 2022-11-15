using System;
using System.Collections.Generic;
namespace Cafeteria_Card_Management
{
    public static partial class Operations
    {   
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<CartItems> cartList=new List<CartItems>();
        private static UserDetails currentUser;
        public static void DefaultData()
        {
            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",8857777575,"ravi@gmail.com",Enum.Parse<Gender>("Male"),101,400);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",9577747744,"baskaran@gmail.com",Enum.Parse<Gender>("Male"),105,500);
            userList.Add(user1);
            userList.Add(user2);
            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,10);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            OrderDetails order1=new OrderDetails("SF1001",new DateTime(2022,06,15),70,Enum.Parse<OrderStatus>("Ordered"));
            OrderDetails order2=new OrderDetails("SF1002",new DateTime(2022,06,15),100,Enum.Parse<OrderStatus>("Ordered"));
            orderList.Add(order1);
            orderList.Add(order2);
            CartItems cart1=new CartItems("OID1001","FID101",20,1);
            CartItems cart2=new CartItems("OID1001","FID103",10,1);
            CartItems cart3=new CartItems("OID1001","FID105",40,1);
            CartItems cart4=new CartItems("OID1002","FID103",10,1);
            CartItems cart5=new CartItems("OID1002","FID104",50,1);
            CartItems cart6=new CartItems("OID1002","FID105",40,1);
            cartList.Add(cart1);
            cartList.Add(cart2);
            cartList.Add(cart3);
            cartList.Add(cart4);
            cartList.Add(cart5);
            cartList.Add(cart6);
        }
        public static void MainMenu()
        {
            int choice;
            bool temp;
            do{
                System.Console.WriteLine("Welcome to Ak Cafeteria");
                System.Console.WriteLine("1.New User Registration");
                System.Console.WriteLine("2.User Login");
                System.Console.WriteLine("3.Exit");
                System.Console.Write("Enter your choice     :");
                temp=int.TryParse(Console.ReadLine(),out choice);
                while(!temp)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    System.Console.WriteLine("Invalid Input.Enter again...");
                    Console.ResetColor();
                    System.Console.Write("Enter your choice     :");
                    temp=int.TryParse(Console.ReadLine(),out choice);
                }
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome to New User Registration");
                        NewRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        LoginMenu();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exited from the application");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Input.Enter again....");
                        break;
                    }
                }
            }while(choice!=3);
        }
//         a.	UserName
// b.	FatherName
// c.	MobileNumber
// d.	MailID
// e.	Gender
// f.	WorkStationNumber (Be like WS101) 
// g.	Balance

        public static void NewRegistration()
        {
            bool temp;
            System.Console.Write("Enter your name                        :");
            string name=Console.ReadLine();
            System.Console.Write("Enter your father name                 :");
            string fatherName=Console.ReadLine();
            System.Console.Write("Enter your mobile number               :");
            long mobile;
            temp=long.TryParse(Console.ReadLine(),out mobile);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input.Enter again....");
                System.Console.Write("Enter your mobile number               :");
                temp=long.TryParse(Console.ReadLine(),out mobile);
            }
            System.Console.Write("Enter your mailID                      :");
            string mail=Console.ReadLine();
            System.Console.Write("Enter your Gender                      :");
            Gender gender;
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input.Enter again....");
                System.Console.Write("Enter your Gender                      :");
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            System.Console.Write("Enter your work station number         :");
            int workStationNumber;
            temp=int.TryParse(Console.ReadLine(),out workStationNumber);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input.Enter again....");
                System.Console.Write("Enter your work station number         :");
                temp=int.TryParse(Console.ReadLine(),out workStationNumber);
            }
            UserDetails newUser=new UserDetails(name,fatherName,mobile,mail,gender,workStationNumber);
            userList.Add(newUser);
            System.Console.WriteLine("Registration Successful...");
            System.Console.WriteLine("Your generated userID is "+newUser.UserID);
        }
//         a.	Show My Profile
// b.	Food Order
// c.	Cancel Order
// d.	Order History
// e.	Wallet Recharge
// f.	Exit

        public static void LoginMenu()
        {
            bool flag=true;
            System.Console.Write("Enter your UserID             :");
            string userID=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(user.UserID.Equals(userID))
                {
                    flag=false;
                    currentUser=user;
                    System.Console.WriteLine("User found.LoginSuccessful...");
                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("User Not Found.....");
            }
        }
        public static void SubMenu()
        {
            char choice;
            do{
                System.Console.WriteLine("Welcome "+currentUser.Name);
                System.Console.WriteLine("a.Show My Profile");
                System.Console.WriteLine("b.Food Order");
                System.Console.WriteLine("c.Cancel Order");
                System.Console.WriteLine("d.Order History");
                System.Console.WriteLine("e.Wallet Recharge");
                System.Console.WriteLine("f.Exit");
                System.Console.Write("Enter your choice        :");
                choice=Console.ReadLine().ToLower()[0];
                switch(choice)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Hi ",currentUser.Name);
                        ShowCustomerProfile();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Order your food");
                        FoodOrder();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Your Order History");
                        OrderHistory();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Wallet Recharge");
                        WalletRecharge();
                        break;
                    }
                    case 'f':
                    {
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Input...");
                        break;
                    }
                }
            }while(choice!='f');
        }
        // 1.display food items which are all in stock
        // 2.Object creation for order details
        // 3.User input foodid and quantity and calculate its FoodPrice
        // 4.check the foodid. If found check stock, not found display invalid food id.
        // 5.create cart item object
        // 6.add the object to cartitem list.
        // 7.ask do you want to order another items if yes repeat the step from 3 to 6.
        public static void FoodOrder()
        {
            bool temp=true;
            string choice="";
            string confirmation="yes";
            System.Console.WriteLine("|-----------------------------------------------------------|");
            System.Console.WriteLine("|  FoodID  |    FoodName    |   Price   | AvailableQuantity |");
            System.Console.WriteLine("|-----------------------------------------------------------|");
            foreach(FoodDetails food in foodList)
            {
        // 1.display food items which are all in stock
                if(food.AvailableQuantity>0)
                {
                    temp=false;
                    food.ShowFoodDetails();
                }
            }
            System.Console.WriteLine("|-----------------------------------------------------------|");
            if(temp)
            {
                System.Console.WriteLine("Sorry. There is no availabilty of food right now");
                return;
            }
        // 2.Object creation for order details
            OrderDetails order =new OrderDetails(currentUser.UserID,DateTime.Today,0,OrderStatus.Initiated);
        // creation of temp list
            List<CartItems> tempCartList=new List<CartItems>();
            do{
        // 3.User input foodid and quantity and calculate its FoodPrice
                temp=true;
                System.Console.Write("Enter the foodID you want to purchase             :");
                string foodID=Console.ReadLine().ToUpper();
                foreach(FoodDetails food in foodList)
                {
        // 4.check the foodid. If found check stock, not found display invalid food id.
                    if(food.FoodID.Equals(foodID))
                    {
                        do
                        {
                            choice="no";
                            temp=false;
                            System.Console.Write("Enter the Quantity of food                            :");
                            int quantity;
                            bool flag=int.TryParse(Console.ReadLine(),out quantity);
                            while(!flag||quantity<0)
                            {
        // 5.Enter the quantity of food.
                                System.Console.WriteLine("Invalid Input.Enter again....");
                                System.Console.WriteLine("Enter the Quantity of food                            :");
                                flag=int.TryParse(Console.ReadLine(),out quantity);
                            }
                            if(food.AvailableQuantity>quantity)
                            {
        //6.check the avaialabilty qunatity of food 
                                double price=food.FoodPrice*quantity;
        // 7.Object creation for cart items
                                CartItems newCart=new CartItems(order.OrderID,foodID,price,quantity);
                                tempCartList.Add(newCart);
                                food.AvailableQuantity-=+quantity;
                                System.Console.WriteLine("Item added to the cart");
                                System.Console.Write("Do you want to order another food    :");
                                confirmation=Console.ReadLine().ToLower();
                            }
                            else if(food.AvailableQuantity==0)
                            {
                                System.Console.WriteLine("Insufficient stock. Purchase some other food");
                            }
                            else
                            {
                                System.Console.WriteLine("Please enter the stock less than "+food.AvailableQuantity);
                                System.Console.Write("Do you want to reduce the quantity of an item    :");
                                choice=Console.ReadLine().ToLower();
                            }
                        }while(choice=="yes");

                    }
                }
                if(temp)
                {
                    System.Console.WriteLine("Invalid FoodID");
                }
            }while(confirmation=="yes");

            do{
                System.Console.Write("Do you want to confirm the order    :");
                choice=Console.ReadLine().ToLower();
                double totalPrice=0;
                if(choice=="yes")
                {
                    foreach(CartItems items in tempCartList)
                    {
                        totalPrice+=items.OrderPrice;
                    }
                    
                    if(currentUser.WalletBalance>=totalPrice)
                    {
                        currentUser.WalletBalance-=totalPrice;
                        cartList.AddRange(tempCartList);
                        order.TotalPrice=totalPrice;
                        order.OrderStatus=OrderStatus.Ordered;
                        orderList.Add(order);
                        System.Console.WriteLine("Order placed successfully...Your orderID is "+order.OrderID);
                        return;
                    }
                    else{
                        System.Console.WriteLine("Insufficient Balance");
                        System.Console.Write("Do you want to Recharge your wallet      :");
                        choice=Console.ReadLine().ToLower();
                        if(choice=="yes")
                        {
                            WalletRecharge();
                        }
                    }
                }
            }while(choice=="yes");
            
            System.Console.WriteLine("Exited without ordering");
            foreach(CartItems cart in tempCartList)
            {
                foreach(FoodDetails food in foodList)
                {
                    if(cart.FoodID.Equals(food.FoodID))
                    {
                        food.AvailableQuantity+=cart.OrderQuantity;
                    }
                }
            }
        }
        private static void ShowCustomerProfile()
        {
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|  UserID  |     UserName     |   FatherName   | MobileNumber |     MailID     |   Gender   | WorkStationNumber | WalletBalance |");
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------------|");
            currentUser.ShowUserDetails();
            System.Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------------|");
        }
        private static void CancelOrder()
        {
            // displaying the order details of current customer whose status is in ordered
            bool temp=true;
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            System.Console.WriteLine("|  OrderID  |  UserID  |  OrderDate  |  TotalPrice  |  OrderStatus  |");
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(currentUser.UserID)&&order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    temp=false;
                    order.ShowOrderDetails();
                }
            }
            if(temp)
            {
                System.Console.WriteLine("|There is no order from the customer                                |");
                System.Console.WriteLine("|-------------------------------------------------------------------|");
                return;
            }
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            // user input for cancelling order
            System.Console.Write("Enter the orderID to be cancelled    :");
            string orderID=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in orderList)
            {
                // checking the given order id is in orderlist
                if(order.OrderID.Equals(orderID))
                {
                    temp=false;
                    // check whether the order is ordered or not
                    if(order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        System.Console.Write("Do you want to cancel your order     :");
                        string choice=Console.ReadLine().ToLower();
                        if(choice=="yes")
                        {
                            currentUser.WalletBalance+=order.TotalPrice;
                            foreach(CartItems cart in cartList)
                            {
                                if(order.OrderID.Equals(cart.OrderID))
                                {
                                    foreach(FoodDetails food in foodList)
                                    {
                                        if(food.FoodID.Equals(cart.FoodID))
                                        {
                                            food.AvailableQuantity+=cart.OrderQuantity;
                                        }
                                    }
                                }
                            }
                            System.Console.WriteLine("Order cancelled successfully");
                            order.OrderStatus=OrderStatus.Cancelled;
                        }
                        else{
                            System.Console.WriteLine("Exited without cancelling..");
                            return;
                        }
                    }
                    else{
                        System.Console.WriteLine("Entered orderID is cancelled already...");
                    }
                }
            }
            if(temp)
            {
                System.Console.WriteLine("Invalid OrderID....");
            }
        }
        private static void OrderHistory()
        {
            bool flag=true;
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            System.Console.WriteLine("|  OrderID  |  UserID  |  OrderDate  |  TotalPrice  |  OrderStatus  |");
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            foreach(OrderDetails order in orderList)
            {
                order.ShowOrderDetails();
            }
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            System.Console.Write("Enter the orderID to see the ordered food items  :");
            string orderID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("|------------------------------------------------------------------|");
            System.Console.WriteLine("|  ItemID  |  OrderID  |  FoodID  |  OrderPrice  |  OrderQuantity  |");
            System.Console.WriteLine("|------------------------------------------------------------------|");
            foreach(CartItems items in cartList)
            {
                if(items.OrderID.Equals(orderID))
                {
                    flag=false;
                    items.ShowCartItems();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("|Invalid OrderID....");
            }
            System.Console.WriteLine("|------------------------------------------------------------------|");

        }
        private static void WalletRecharge()
        {
            bool temp;
            System.Console.Write("Enter the amount to be recharged     :");
            double amount;
            temp=double.TryParse(Console.ReadLine(),out amount);
            while(!temp||amount<0)
            {
                System.Console.WriteLine("Invalid Input.Please Enter again..");
                System.Console.WriteLine("Enter the amount to be recharged     :");
                temp=double.TryParse(Console.ReadLine(),out amount);
            }
            currentUser.WalletRecharge(amount);
            System.Console.WriteLine("Recharged Successfully. Available balance is "+currentUser.WalletBalance);
            
        }
    }
}