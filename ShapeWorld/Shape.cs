namespace ShapeWorld
{
	class Shape
	{
		int lines = 4;
		int corners = 4;
		int hLength = 4;
		int vLength = 4;

		protected virtual double Surface()
		{
			return 0;
		}
		protected virtual double Volume()
		{
			return 0;
		}
	}
}