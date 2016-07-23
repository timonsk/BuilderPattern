using System;
namespace House
{
	public class House
	{
		private Basement _basement;
		private Floor _floor;
		private Roof _roof;

		public void Add(IPart part) 
		{
			if (part is Basement)
			{
				_basement = (Basement)part;
			}
			if (part is Floor)
			{
				_floor = (Floor)part; 
			}
			if (part is Roof)
			{
				_roof = (Roof)part;
			}
		}

		public string GetInfo() 
		{
			return string.Format("House type: {0}\n -- Basment:\n     Deep: {1}\n     Size: {2}\n -- Floor:\n"+
			                     "     Size: {3}\n -- Roof:\n     Hieght:{4}\n     Size:{5}"
			                     ,_floor.Type, _basement.Deep, _basement.Size, _floor.Size, _roof.Height, _roof.Size);
		}

	}
}

