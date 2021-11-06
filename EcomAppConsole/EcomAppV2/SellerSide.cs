using System;
using System.Collections.Generic;

namespace EcomAppV2
{
    class SellerSide
    {
        internal static void Go()
        {
            int fig;
            do
            {
                Console.WriteLine("Press 0 to Go Back");
                Console.WriteLine($"SnapKart > Admin > Administrator > Seller Side >");
                Console.WriteLine();
                Console.WriteLine($"Press 1 to Add a new Seller {Environment.NewLine}" +
                                  $"Press 2 to View all Sellers {Environment.NewLine}" +
                                  $"Press 3 to Remove a Seller  {Environment.NewLine}");

                fig = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (fig == 1)
                {
                    Seller.AddSeller();
                }

                else if (fig == 2)
                {
                    Seller.ViewAllSeller();
                }
                else if (fig == 3)
                {
                    Seller.RemoveSeller();
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
    }
}
