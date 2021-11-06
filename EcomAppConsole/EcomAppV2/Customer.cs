using System;
using System.Collections.Generic;

namespace EcomAppV2
{
    class Customer
    {
        static Dictionary<string, CustTemplate> CustomerList = new Dictionary<string,CustTemplate>();
        internal static void Go()
        {
            int fig;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 0 to Go Back.");
                Console.WriteLine($"SnapKart > Customer >");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Press 1 if you are an New User :{Environment.NewLine} " +
                                  $"Press 2 if you are a Existing User : {Environment.NewLine} ");

                fig = Convert.ToInt32(Console.ReadLine());

                if (fig == 1)
                {
                    NewCust();
                }
                else if (fig == 2)
                {
                    ExistingCust();
                }
                if(fig != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (fig != 0);
            
        }


        private static void ExistingCust()
        {
            Console.Clear();
            Console.WriteLine($"Welcome back");            
            Console.WriteLine("Press 0 to Go Back.");
            Console.WriteLine($"SnapKart > Customer > Existing Customer >");
            Console.WriteLine();
            Console.WriteLine($"Please enter your Username :");
            var user = Console.ReadLine();
            Console.WriteLine("Enter your Password : ");
            var pass = Console.ReadLine();

            while (CustomerList.ContainsKey(user) == false || CustomerList[user].password != pass)
            {
                Console.WriteLine("Wrong Credentials, Please retry");
                Console.WriteLine($"Please enter your Username :");
                user = Console.ReadLine();
                Console.WriteLine("Enter your Password : ");
                pass = Console.ReadLine();
            }
            Login(user);
        }

        private static void NewCust()
        {
            Console.Clear();
            Console.WriteLine("Press 0 to Go Back.");
            Console.WriteLine($"SnapKart > Customer > New Customer >");
            Console.WriteLine();
            Console.WriteLine("Please Complete your profile to signup up.");
            Console.WriteLine("Please Enter a unique Username :");
            var user = Console.ReadLine();
            while(CustomerList.ContainsKey(user) == true)
            {
                Console.WriteLine($"Username already taken, Please retry :");
                user = Console.ReadLine();
            }
            Console.WriteLine("Enter Password :");
            var pass = Console.ReadLine();

            Console.WriteLine("Enter you Name :");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your Address : ");
            var address = Console.ReadLine();

            CustTemplate newCust = new CustTemplate();
            newCust.password = pass;
            newCust.name = name;
            newCust.address = address;

            CustomerList.Add(user, newCust);

            Login(user);
        }

        internal static void Login(string user)
        {
            int fig;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 0 to Go Back.");
                Console.WriteLine($"SnapKart > Customer > Customer Login > Profile");
                Console.WriteLine();

                Console.WriteLine($"Welcome {user}!");
                Console.WriteLine("Press 1 to Start Shopping");
                Console.WriteLine("Press 2 to Go to MyCart");
                Console.WriteLine("Press 3 to Go to MyOrder");

                fig = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (fig == 1)
                {
                    GoToShopping(user);

                }
                else if (fig == 2)
                {
                    Cart.Go(user);
                }
                else if (fig == 3)
                {
                    Order.Go(user);
                }
                if(fig != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (fig != 0);


        }

        private static void GoToShopping(string user)
        {
            int prod_id;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 0 to Go Back.");
                Console.WriteLine($"SnapKart > Customer > Customer Login > Profile > Shopping >");
                Console.WriteLine();

                Products.Catalogue();
                Console.WriteLine();

                Console.WriteLine("To Add Product to the Cart, Enter Product ID :");
                prod_id = Convert.ToInt32(Console.ReadLine());
                if(prod_id == 0)
                {
                    break;
                }
                Console.WriteLine($"Enter Quantity for this Product :");
                var Prod_qu = Convert.ToInt32(Console.ReadLine());

                Cart.AddToCart(user, prod_id, Prod_qu);
                Console.WriteLine();
                Console.WriteLine("Press any key to Continue");
                Console.ReadKey();

            } while (prod_id != 0);
            
        }
  

        internal static void ViewAllCustomers()
        {
            Console.WriteLine("Username        Name        Address");
            Console.WriteLine("------------------------------------");
            foreach (KeyValuePair<string, CustTemplate> ele in CustomerList)
            {
                Console.WriteLine($"{ele.Key}       {ele.Value.name}        {ele.Value.address}");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
