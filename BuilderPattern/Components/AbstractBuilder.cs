namespace Components
{
	using House;

	public abstract class AbstractBuilder
	{
		public abstract Basement BuildBasement();
		public abstract Floor BuildFloor();
		public abstract Roof BuildRoof();
	}
}

