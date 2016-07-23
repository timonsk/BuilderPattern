using System;
using House;
using Components;

namespace BuilderPattern
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			var stoneBuilder = new StoneBuilder();
			var woodBuilder = new WoodBuilder();

			var foreman = new Foreman();

			var stoneHouse = foreman.Build(stoneBuilder);
			var woodHouse = foreman.Build(woodBuilder);

			Console.WriteLine();
			Console.WriteLine(stoneHouse.GetInfo());
			Console.WriteLine(woodHouse.GetInfo());
			Console.ReadKey();
		}
	}
}
