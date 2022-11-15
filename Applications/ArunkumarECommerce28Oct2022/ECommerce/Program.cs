using System;
using System.Collections.Generic;
namespace ECommerce;
class Program{
     static List<CustomerDetails> customerList=new List<CustomerDetails>();
    static List<OrderDetails> orderList=new List<OrderDetails>();
    static List<ProductDetails> productList=new List<ProductDetails>();
    public static void Main(string[] args)
    {
        
        customerList=DefaultDetailsOfCustomer(customerList);
        orderList=DefaultDetailsOfOrder(orderList);
        productList=DefaultDetailsOfProduct(productList);
        int choice;
        char choose;
        menu:
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("                                     Main Menu");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("1.Registration");
        Console.WriteLine("2.Login");
        Console.WriteLine("3.Exit");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.Write("Enter your choice: ");
        choice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("------------------------------------------------------------------------------------------");

        if(choice==1)
        {
            Console.Write("Enter your name               : ");
            string name=Console.ReadLine();
            Console.Write("Enter your city               : ");
            string city=Console.ReadLine();
            Console.Write("Enter your mobile number      : ");
            string mobile=Console.ReadLine();
            Console.Write("Enter the amount to be added  : ");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your mailID              : ");
            string mailID=Console.ReadLine();
            CustomerDetails customer=new CustomerDetails(name,city,mobile,amount,mailID);
            customerList.Add(customer);
            Console.WriteLine("Your customerID is generated: "+customer.CustomerID);
            goto menu;
        }
        else if(choice==2)
        {
            Console.Write("Enter your customerID: ");
            string custId=Console.ReadLine();
            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerID==custId)
                {
                    submenu:
                    LoginMenu();
                    choose=Console.ReadLine()[0];
                    switch(choose)
                    {
                        case 'a':
                        {
                            ShowPurchase(productList);
                            Purchase(customer,custId);
                            goto submenu;
                        }
                        case 'b':
                        {
                            OrderHistory(customer,custId);
                            goto submenu;
                        }
                        case 'c':
                        {
                            CancelOrder(customer,custId);
                            goto submenu;
                        }
                        case 'd':
                        {
                            WalletBalance(customer,custId);
                            goto submenu;
                        }
                        case 'e':
                        {
                            goto menu;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid input");
                            goto submenu;
                        }
                    }
                }
            }
        }
        else{
            Console.Write("Exited from the application");
        }
    }
    static void LoginMenu()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("                                     Sub Menu");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("a.Purchase");
        Console.WriteLine("b.Order History");
        Console.WriteLine("c.Cancel Order");
        Console.WriteLine("d.Wallet Balance");
        Console.WriteLine("e.Exit");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.Write("Enter your choice: ");
        
    }
    static void Purchase(CustomerDetails customer,string custId)
    {
        Console.Write("Enter your productID : ");
        string prodId=Console.ReadLine();
        foreach(ProductDetails product in productList)
        {
            if(prodId==product.ProductID)
            {
                quantity:
                Console.Write("Enter the count to purchase: ");
                int count=Convert.ToInt32(Console.ReadLine());
                if(product.Stock>=count)
                {
                    
                    int totalAmount = (count*product.Price) + 50;
                    Console.WriteLine("Total amount is "+totalAmount);
                    if(custId==customer.CustomerID)
                    {
                        if(totalAmount<=customer.WalletBalance)
                        {
                            customer.RemainingBalance(totalAmount);
                            
                            Console.Write("Confirm Your Order Yes or No:");
                            string confirmation=Console.ReadLine().ToLower();
                            if(confirmation=="yes")
                            {
                                Console.WriteLine("Order placed successfully. Your order will be delivered on "+DateTime.Now.AddDays(product.ShippingDuration).ToShortDateString());
                                product.RemainingStock(count);
                                OrderDetails newOrder=new OrderDetails(totalAmount,prodId,custId,DateTime.Now,count,"Ordered");
                                orderList.Add(newOrder);
                            }
                        }
                        else{
                            Console.WriteLine("“Insufficient Wallet Balance. Please recharge your wallet");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Required count is not availabale. Currently available stock is "+product.Stock);
                    goto quantity;
                }
            }
        }
    }
    static void OrderHistory(CustomerDetails customer,string custId)
    {
        Console.WriteLine("|------------------------------------------------------------------------------------------|");
        Console.WriteLine("| Customer ID | ProductID | TotalPrice | Purchase Date | Quantity Purchased | Order Status |");   
        Console.WriteLine("|------------------------------------------------------------------------------------------|");
        foreach(OrderDetails order in orderList)
        {
            if(custId==order.CustomerID)
            {
                
                Console.WriteLine("|{0,-13}|{1,-11}|{2,-12}|{3,-15}|{4,-20}|{5,-14}|",order.CustomerID,order.ProductID,order.TotalPrice,order.PurchaseDate.ToShortDateString(),order.Quantity,order.OrderStatus);
                Console.WriteLine("|------------------------------------------------------------------------------------------|");
            }
        }
    }
    static void CancelOrder(CustomerDetails customer,string custId)
    {
        Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("| Customer ID |  OrderID  | ProductID | TotalPrice | Purchase Date | Quantity Purchased | Order Status |");   
        Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
        foreach(OrderDetails order in orderList)
        {
            if(custId==order.CustomerID)
            {
                
                Console.WriteLine("|{0,-13}|{1,-11}|{2,-11}|{3,-12}|{4,-15}|{5,-20}|{6,-14}|",order.CustomerID,order.OrderID,order.ProductID,order.TotalPrice,order.PurchaseDate.ToShortDateString(),order.Quantity,order.OrderStatus);
                Console.WriteLine("|------------------------------------------------------------------------------------------------------|");
            }
        }
        Console.Write("Enter the orderId to be cancelled:");
        string ordID=Console.ReadLine();
        for(int i=0;i<orderList.Count;i++)
        {
            if(orderList[i].OrderID==ordID)
            {
                orderList[i].OrderStatus="Cancelled";
                foreach(ProductDetails product in productList)
                {
                    if(orderList[i].ProductID==product.ProductID)
                    {
                        product.RemainingStock(-orderList[i].Quantity);
                    }
                }   
            }
            if(orderList[i].CustomerID==customer.CustomerID)
            {
                customer.WalletBalance=customer.WalletBalance+orderList[i].TotalPrice;
            }
        }
    }
    static void WalletBalance(CustomerDetails customer,string custId)
    {
        Console.WriteLine("Your wallet balance is "+customer.WalletBalance);
        Console.WriteLine("Are you wish to recharge your wallet(yes or no): ");
        string recharge=Console.ReadLine().ToLower();
        if(recharge=="yes")
        {
            Console.Write("Enter the amount to be recharged: ");
            int rechargeAmount=Convert.ToInt32(Console.ReadLine());
            customer.WalletBalanceRecharge(rechargeAmount);
        }
    }
    static void ShowPurchase(List<ProductDetails> productList)
    {
        Console.WriteLine("|--------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|  ProductID  |  Product Name  | Available Stock Quantity |  Price/Quantity  |  Shipping Duration  |");
        
        foreach(ProductDetails product in productList)
        {
            Console.WriteLine("|--------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|{0,-13}|{1,-16}|{2,-26}|{3,-18}|{4,-21}|",product.ProductID,product.ProductName,product.Stock,product.Price,product.ShippingDuration);
        }
        Console.WriteLine("|--------------------------------------------------------------------------------------------------|");
    }
    static List<CustomerDetails> DefaultDetailsOfCustomer(List<CustomerDetails> customerList)
    {
        CustomerDetails customer=new CustomerDetails("Ravi","Chennai","9885858588",50000,"ravi@gmail.com");
        CustomerDetails customer1=new CustomerDetails("Baskar","Chennai","9888475757",60000,"baskaran@gmail.com");
        customerList.Add(customer);
        customerList.Add(customer1);
        return customerList;
    }
    static List<OrderDetails> DefaultDetailsOfOrder(List<OrderDetails> orderList)
    {
        OrderDetails order=new OrderDetails(20000,"PID101","CID1001",DateTime.Now,2,"Ordered");
        OrderDetails order1=new OrderDetails(40000,"PID103","CID1002",DateTime.Now,2,"Ordered");
        orderList.Add(order);
        orderList.Add(order1);
        return orderList;
    }
    static List<ProductDetails> DefaultDetailsOfProduct(List<ProductDetails> productList)
    {
        ProductDetails product=new ProductDetails("Mobile",10,10000,3);
        ProductDetails product1=new ProductDetails("Tablet",5,15000,2);
        ProductDetails product2=new ProductDetails("Camara",3,20000,4);
        ProductDetails product3=new ProductDetails("iPhone",5,50000,6);
        ProductDetails product4=new ProductDetails("Laptop",3,40000,3);
        productList.Add(product);
        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);
        productList.Add(product4);
        return productList;
    }
}