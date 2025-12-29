using System;

class Clothing : Product
{
	public string Size { get; set; }
	public string Material { get; set; }

	public Clothing(string name, double price, string size, string material) : base(name, price)
	{
		Size = size;
		Material = material;
	}

	public override void GetProductDetails()
	{
		base.GetProductDetails();
		Console.WriteLine($"Size: {Size} with {Material} matetrial");
	}
}