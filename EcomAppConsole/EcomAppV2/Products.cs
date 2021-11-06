using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomAppV2
{
    class Products
    {
        internal static Dictionary<int, ProdTemplate> ProductsList = new Dictionary<int, ProdTemplate>();

        internal static void Catalogue()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Seller > Seller > View Catlogue");
            Console.WriteLine();
            Console.WriteLine("Product ID       Name        Price        Stock");
            Console.WriteLine("------------------------------------------------");
            foreach (KeyValuePair<int,ProdTemplate> ele in ProductsList)
            {
                Console.WriteLine($"{ele.Key}       {ele.Value.name}        {ele.Value.price}      {ele.Value.quantity}");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
        }

        internal static void AddProduct()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Seller > Seller > Add Product");
            Console.WriteLine();
            Console.WriteLine("To Add a Product in the Catalogue, Please Enter Product ID :");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name :");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Product Price : ");
            var price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product quantity :");
            var qu = Convert.ToInt32(Console.ReadLine());
 

            var newProd = new ProdTemplate();
            newProd.id = id;
            newProd.name = name;
            newProd.price = price;
            newProd.quantity = qu;

            ProductsList.Add(id , newProd);

            Console.WriteLine("Product added Successfully!");
            Console.WriteLine();
        }

        internal static void RemoveProd()
        {
            Console.WriteLine("Press 0 to Go Back");
            Console.WriteLine($"SnapKart > Seller > Seller > Remove Product");
            Console.WriteLine();
            Console.WriteLine("Enter Product id to Remove it from the Catalogue :");
            var id = Convert.ToInt32(Console.ReadLine());
            ProductsList.Remove(id);
            Console.WriteLine("Product Removed Successfully");
            Console.WriteLine();
        }

        internal static void DecreaseQuant(int id, int qu)
        {
            ProductsList[id].quantity -= qu;

            if (ProductsList[id].quantity == 0)
            {
                ProductsList.Remove(id);
            }
        }
    }
}
