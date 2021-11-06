using System;
using System.Collections.Generic;

namespace EcomAppV2
{
    class CustomerSide
    {
        static internal void Go()
        {
            int fig;
            do
            {
                Console.WriteLine("Press 0 to Go Back");
                Console.WriteLine($"SnapKart > Admin > Administrator > Customer Side >");
                Console.WriteLine();
                Console.WriteLine($"Press 1 to View All Customers {Environment.NewLine}" +
                                  $"Press 2 to View All Orders {Environment.NewLine}");

                fig = Convert.ToInt32(Console.ReadLine());

                if (fig == 1)
                {
                    Customer.ViewAllCustomers();
                }

                else if (fig == 2)
                {
                    Order.ViewAllOrders();
                }
                if (fig != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (fig != 0);
           
        }
    }
}
