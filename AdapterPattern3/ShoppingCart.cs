using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern3
{


	public class ShoppingCart
	{
		List<IItem> items = new List<IItem>();
		private double totPrice;

		public void add(IItem i)
		{
			items.Add(i);
		}

		public void remove(IItem i)
		{
			this.items.Remove(i);
		}

		public double totalPrice()
		{
			totPrice = 0;
			foreach (IItem i in items)
			{
				totPrice += i.itemPrice();
			}
			return totPrice;
		}

		public void display()
		{
			foreach (IItem i in items)
			{
				Console.WriteLine("Item Name: " + i.itemName());
				Console.WriteLine("Item Price: " + i.itemPrice());
			}
			Console.WriteLine("Total Price Of All Items In Cart: " + this.totalPrice());
		}
	}
}
