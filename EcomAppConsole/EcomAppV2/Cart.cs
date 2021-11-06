using System;
using System.Collections.Generic;

namespace EcomAppV2
{
    class Cart
    {
        internal static Dictionary<string, List<ProdTemplate>> CartList = new Dictionary<string, List<ProdTemplate>>();


        internal static void Go(string user)
        {
            int id;
            do
            {
                Console.Clear();
                Console.WriteLine($"Hello {user}, Welcome to your Cart!");
                Console.WriteLine("Press 0 to GoBack or Press 1 to Checkout!");
                Console.WriteLine($"SnapKart > Customer > Customer Login > Profile > Cart >");
                Console.WriteLine();
                ViewCartList(user);
                Console.WriteLine();
                Console.WriteLine("To Remove Product from the Cart, Enter Product Id :");
                id = Convert.ToInt32(Console.ReadLine());
                if (id != 0 && id != 1)
                {
                    RemoveProd(user, id);
                }
                else
                {
                    if (id == 1)
                    {
                        Order.PlaceOrder(user);
                        CartList[user].Clear();
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Press any Key to Continue.");
                Console.ReadKey();

            } while(id != 0);
            
        }


        internal static void ViewCartList(string user)
        {
            Console.WriteLine("Product Id       Name        Price       Quantity");
            Console.WriteLine("-------------------------------------------------");
            foreach(ProdTemplate ele in CartList[user])
            {
                Console.WriteLine($"{ele.id}        {ele.name}      {ele.price}     {ele.quantity}");
            }
        }

        internal static void AddToCart(string user, int prod_id, int prod_qu)
        {
            var newProd = new ProdTemplate();
            newProd.id = prod_id;
            newProd.quantity = prod_qu;
            newProd.name = Products.ProductsList[prod_id].name;
            newProd.price = Products.ProductsList[prod_id].price;
            
            if(CartList.ContainsKey(user) == false)
            {
                var prodList = new List<ProdTemplate>();
                newProd.quantity = StockCond(prod_id, prod_qu);
                prodList.Add(newProd);
                CartList[user] = prodList;
            }
            else
            {
                var index = CheckForSameProdInCart(user, prod_id);
                if (index >= 0)
                {
                    newProd.quantity = StockCond(prod_id, prod_qu + CartList[user][index].quantity);
                    CartList[user][index].quantity = newProd.quantity;
                }
                else
                {
                    newProd.quantity = StockCond(prod_id, prod_qu);
                    CartList[user].Add(newProd);
                }                
            }
            
            Console.WriteLine("Product Successfully Added to Cart");
        }

        private static int StockCond(int prod_id, int prod_qu)
        {
            var availability = Products.ProductsList[prod_id].quantity;
            if(prod_qu <= availability)
            {
                return prod_qu;
            }
            else
            {
                Console.WriteLine("Total quanity in cart can not exceed availbaility, " +
                    "Adding maximum available quanity to the Cart");
                return availability;
            }
        }

        private static int CheckForSameProdInCart(string user, int prod_id)
        {
            var i = 0;
            foreach(var prod in CartList[user])
            {
                if(prod.id == prod_id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private static void RemoveProd(string user, int id)
        {
            foreach(ProdTemplate ele in CartList[user])
            {
                if(ele.id == id)
                {
                    CartList[user].Remove(ele);
                    break;
                }
            }
            Console.WriteLine("Product Successfully Removed from Cart");
        }
    }
}
