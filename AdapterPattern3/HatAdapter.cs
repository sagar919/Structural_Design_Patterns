using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern3
{
	public class HatAdapter : IItem
	{

	private Hat hat;

	public HatAdapter(Hat hat)
	{
		this.hat = hat;
	}

	
	public string itemName()
	{
		return hat.getLongName();
	}

	
	public double itemPrice()
	{
		return hat.getPrice();
	}


}
}
