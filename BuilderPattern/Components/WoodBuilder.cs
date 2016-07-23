using System;
namespace Components
{
	using House;

	public class WoodBuilder : AbstractBuilder
	{
		private Random _random;

		public WoodBuilder()
		{
			_random = new Random();
		}

		public override Basement BuildBasement()
		{
			Console.WriteLine("Start building the basement...");
			var basement = new Basement() { Size = _random.Next(0, 10), Deep = _random.Next(0, 20) };
			Console.WriteLine("Finished building the basement!");
			return basement;
		}

		public override Floor BuildFloor()
		{
			Console.WriteLine("Start building the floor...");
			var floor = new Floor() { Height = _random.Next(1, 3), Width = _random.Next(10, 40), Type = "Wood" };
			Console.WriteLine("Finished building the floor!");
			return floor;
		}

		public override Roof BuildRoof()
		{
			Console.WriteLine("Start building the roof...");
			var roof = new Roof() { Size = _random.Next(10, 40), Height = _random.Next(2, 5) };
			Console.WriteLine("Finished building the roof!");
			return roof;
		}
	}
}

