using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; protected set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual void GetProductDetails()
    {
        Console.WriteLine($"Product Name: {Name} and Price : {Price}");
    }
}