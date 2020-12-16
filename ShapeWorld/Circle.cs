using System;

namespace ShapeWorld
{
	class Circle : Shape
	{
		internal double Radius;
		protected override double Surface()
		{
			return Math.PI * Radius * Radius;
		}
	}

}