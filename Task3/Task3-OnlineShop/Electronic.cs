using System;

class Electronic : Product, IDiscountable
{
	public int Warranty { get; set; }

	public Electronic(string name, double price, int warranty) : base(name, price)
	{
		Warranty = warranty;
	}

	public void ApplyDiscount(double percent)
	{
		Price -= Price * percent / 100;
	}

	public override void GetProductDetails()
	{
		base.GetProductDetails();
		Console.WriteLine($"Warranty : {Warranty} months");
	}
}
