// See https://aka.ms/new-console-template for more information
class Program
{
    static List<Product> products = new List<Product>();
    static void Main(string[] args)
    {
        bool OpenMneu = false;

        while (!OpenMneu)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddElectronic();
                    break;
                case "2":
                    AddClothing();
                    break;
                case "3":
                    ShowProducts();
                    break;
                case "4":
                    OpenMenu = true;
                    break;
                    
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Online Shop Menu ");
        Console.WriteLine("1. Add Electronic Product");
        Console.WriteLine("2. Add Clothing Product");
        Console.WriteLine("3. Show All Products");
        Console.WriteLine("4. Exit");
        Console.Write("Choose option: ");
    }

    static void AddElectronic()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter warranty : ");
        int warranty = int.Parse(Console.ReadLine());

        Console.Write("Enter discount percent: ");
        double discount = double.Parse(Console.ReadLine());

        Electronic electronic = new Electronic(name, price, warranty);
        electronic.ApplyDiscount(discount);

        products.Add(electronic);
        Console.WriteLine("Electronic product added !");
    }

    static void AddClothing()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter size: ");
        string size = Console.ReadLine();

        Console.Write("Enter material: ");
        string material = Console.ReadLine();

        Clothing clothing = new Clothing(name, price, size, material);
        products.Add(clothing);

        Console.WriteLine("Clothing product added !");
    }

    static void ShowProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("There isnt any product");
            return;
        }

        Console.WriteLine(" Product List");
        foreach (Product product in products)
        {
            product.GetProductDetails();
        
        }
    }
}