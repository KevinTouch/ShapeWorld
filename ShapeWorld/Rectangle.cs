namespace ShapeWorld
{
	class Rectangle : Shape
	{
		internal double Length;
		internal double Width;

		protected override double Volume()
		{
			return Length * Width;
		}
	}
}