using System;
namespace House
{
	public class Floor : IPart
	{
		public int Size { get { return Width * Height;} set { } }
		public int Height { get; set; }
		public int Width { get; set; }
		public string Type { get; set; }
	}
}

