using System;
namespace Components
{
	using House;

	public class Foreman
	{
		public House Build(AbstractBuilder builder) 
		{
			var house = new House();
			house.Add(builder.BuildBasement());
			house.Add(builder.BuildFloor());
			house.Add(builder.BuildRoof());
			return house;
		}
	}
}

