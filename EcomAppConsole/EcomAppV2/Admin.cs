using System;
using System.Collections.Generic;

namespace EcomAppV2
{
    class Admin
    {
        internal static void Go()
        {
            const string login = "1";
            const string pass = "1";

            //Console.Clear();
            //Console.WriteLine("Enter 0 to Go Back :");
            Console.WriteLine($"SnapKart > Admin >");
            Console.WriteLine();

            Console.WriteLine($"Please Enter your Login ID : ");
            var id = Console.ReadLine();
            Console.WriteLine($"Please Enter your Password : ");
            var word = Console.ReadLine();

            while(login != id || pass != word)
            {
                //Console.Clear();
                //Console.WriteLine("Enter 0 to Go Back :");
                Console.WriteLine($"SnapKart > Admin >");
                Console.WriteLine();

                Console.WriteLine("Wrong Credentials, Please retry");
                Console.WriteLine($"Please Enter your Login ID : ");
                id = Console.ReadLine();
                Console.WriteLine($"Please Enter your Password : ");
                word = Console.ReadLine();
            }
            Console.Clear();
            Options();
            //Console.ReadKey();

        }

        internal static void Options()
        {
            int fig;
            do
            {
               // Console.Clear();
                Console.WriteLine("Login Succeeded, Welcome!");
                Console.WriteLine("Press 0 to Go Back");
                Console.WriteLine($"SnapKart > Admin > Administrator");
                Console.WriteLine();               
                Console.WriteLine("Press 1 for Seller Side Controls ");
                Console.WriteLine("Press 2 for Customer Side Controls ");
                Console.WriteLine("Press 3 to View Product Catalogue");

                fig = Convert.ToInt32(Console.ReadLine());

                if (fig == 1)
                {
                    Console.Clear();
                    SellerSide.Go();
                }
                else if (fig == 2)
                {
                    Console.Clear();
                    CustomerSide.Go();
                }
                else if (fig == 3)
                {
                    Console.Clear();
                    Products.Catalogue();
                }
            } while (fig != 0);

            //Console.ReadKey();
        }
    }
}
