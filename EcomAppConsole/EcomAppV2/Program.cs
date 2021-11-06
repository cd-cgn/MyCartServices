using System;
using System.Collections.Generic;
namespace EcomAppV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fig;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 0 to abort Application!");
                Console.WriteLine($"Welcome to SnapKart.com, We wish you a happy shopping experience!");
                Console.WriteLine("SnapKart >");
                Console.WriteLine($"If you are an Admin   : Press 1");
                Console.WriteLine($"If you are a Seller   : Press 2");
                Console.WriteLine($"If you are a Customer : Press 3");
                Console.WriteLine();
                fig = Convert.ToInt32(Console.ReadLine());

                if (fig == 1)
                {
                    Console.Clear();
                    Admin.Go();
                }

                else if (fig == 2)
                {
                    Console.Clear();
                    Seller.Go();
                }

                else if (fig == 3)
                {
                    Console.Clear();
                    Customer.Go();

                }
               
            } while (fig != 0);

            //Console.ReadKey();
        }
    }
}
