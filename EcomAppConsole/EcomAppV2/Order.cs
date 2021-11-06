using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomAppV2
{
    class Order
    {
        static Dictionary<string, List<ProdTemplate>> OrderList = new Dictionary<string, List<ProdTemplate>>();

        internal static void Go(string user)
        {
            Console.Clear();
            Console.WriteLine("Press 0 to Go Back.");
            Console.WriteLine($"SnapKart > Customer > Customer Login > Profile > MyOrder >");
            Console.WriteLine();
            Console.WriteLine($"Hello {user}, Welcome to your Order List!");
            ViewOrderList(user);
        }

        internal static void ViewOrderList(string user)
        {
            Console.WriteLine();
            Console.WriteLine("Product Id       Name        Price       Quantity");
            Console.WriteLine("-------------------------------------------------");
            foreach (ProdTemplate ele in OrderList[user])
            {
                Console.WriteLine($"{ele.id}        {ele.name}      {ele.price}     {ele.quantity}");
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }

        internal static void PlaceOrder(string user)
        {
            var newOrderList = new List<ProdTemplate>();
        
            foreach (ProdTemplate prod in Cart.CartList[user])
            {
                newOrderList.Add(prod);
                Products.DecreaseQuant(prod.id, prod.quantity);
            }
            
            OrderList[user] = newOrderList;
            Console.WriteLine("Order Placed Successfully!");
        }

        

        internal static void ViewAllOrders()
        {

            foreach(KeyValuePair<string,List<ProdTemplate>> ele in OrderList)
            {
                Console.WriteLine();
                Console.WriteLine("*********************");
                Console.WriteLine($"Customer Username : << {ele.Key} >>");
                Console.WriteLine("*********************");
                ViewOrderList(ele.Key);
            }
        }



    }
}
