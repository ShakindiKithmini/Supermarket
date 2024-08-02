using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json;

namespace super_market_new
{
    internal class Program
    {
        static List<Product> ProductList = new List<Product>();


        static void Main(string[] args)
        {

            Product product1 = new Product(1, "Apple", 50);
            Product product2 = new Product(2, "Cake", 200);

            ProductList.Add(product1);
            ProductList.Add(product2);

            string jsonString = JsonSerializer.Serialize(product1);

            File.WriteAllText("product1.json", jsonString);

            Console.WriteLine("Welcome to CPM supermarket");
            Console.WriteLine("Enter 'C' to create a new product");
            Console.WriteLine("Enter 'S' to show product list");
            Console.WriteLine("Enter 'Q' to quite form the system");

            Console.WriteLine("Enter your choice:");
            char choice = Convert.ToChar(Console.ReadLine().ToUpper());

            while (true)
            {
                if (choice == 'C')
                {
                    CreateProduct();
                }
                else if (choice == 'S')
                {
                    ShowProductList();
                }
                else if (choice == 'Q')
                {
                    Console.WriteLine("Thank you");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 'C' or 'S'");
                }

                Console.WriteLine("Enter your choice:");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());
            }

        }

        static void ShowProductList()
        {
            Console.WriteLine("--- Product List ---");
            Console.WriteLine("Product ID | category | Price");
            foreach (Product p in ProductList)
            {
                Console.WriteLine($"{p.ProductID}   |{p.Category}   |{p.Price}  |{p.VAT}");
            }
        }

        static void CreateProduct()
        {
            Console.WriteLine("Enter product ID :");
            int productID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter category:");
            string category = Console.ReadLine();

            Console.WriteLine("Enter price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Product newProduct = new Product(productID, category, price);
            ProductList.Add(newProduct);
        }