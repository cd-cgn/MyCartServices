using System;
using System.Collections.Generic;


namespace EcomAppV2
{
    class Seller
    {
        static Dictionary<string,string> SellerList = new Dictionary<string,string>();

        internal static void Go()
        {
            Console.Clear();
            Console.WriteLine($"SnapKart > Seller >");
            Console.WriteLine();
            Console.WriteLine($"To login Enter Username :");
            var user = Console.ReadLine();
            Console.WriteLine($"Enter Password");
            var pass = Console.ReadLine();

            while (SellerList.ContainsKey(user) == false || SellerList[user] != pass )
            {
                Console.WriteLine("Wrong Credentials, Please retry");    
            }
            Login(user);

            //Console.ReadKey();
        }


        private static void Login(string user)
        {
            int fig;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 0 to Logout");
                Console.WriteLine($"Login Succeeded, Welcome {user}! ");
                Console.WriteLine($"SnapKart > Seller > Seller");
                Console.WriteLine();
                Console.WriteLine($"Press 1 to Add Product {Environment.NewLine}" +
                                  $"Press 2 to view Product Catalogue {Environment.NewLine}" +
                                  $"Press 3 to remove a Product {Environment.NewLine}");

                fig = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (fig == 1)
                {
                    Products.AddProduct();
                }
                else if (fig == 2)
                {
                    Products.Catalogue();                   
                }
                else if (fig == 3)
                {
                    Products.RemoveProd();
                }
                if(fig != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (fig != 0);
            //Console.WriteLine("Press any key to Continue.");
            //Console.ReadKey();
            Console.WriteLine();

        }

        internal static void  AddSeller()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Admin > Administrator > Seller Side > Add Seller >");
            Console.WriteLine();
            Console.WriteLine("Enter unique username to Add a Seller:");
            var user = Console.ReadLine();

            while(SellerList.ContainsKey(user) == true)
            {
                Console.WriteLine("Entered username already exists, please enter a unique username.");
                user = Console.ReadLine();
            }
            Console.WriteLine("Enter Password :");
            var pass = Console.ReadLine();

            SellerList.Add(user, pass);
            Console.WriteLine("Seller Succesfully Added!");
        }

        internal static void ViewAllSeller()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Admin > Administrator > Seller Side > View All Seller >");
            Console.WriteLine();
            Console.WriteLine("Seller Name");
            Console.WriteLine("------------");
            foreach (KeyValuePair<string, string> ele in SellerList)
            {
                Console.WriteLine("{0}", ele.Key);
            }
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        internal static void RemoveSeller()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Admin > Administrator > Seller Side > Remove a Seller >");
            Console.WriteLine();
            Console.WriteLine("Add username of the seller to be removed :");
            var user = Console.ReadLine();
            while (SellerList.ContainsKey(user) == false)
            {
                Console.WriteLine("Entered seller doesnot exists, please retry.");
                user = Console.ReadLine();
            }
            SellerList.Remove(user);
            Console.WriteLine("Seller Successfully Removed");
        }

    }
}
