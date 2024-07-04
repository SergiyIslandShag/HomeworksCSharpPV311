namespace _08_Inheritance__Indexers
{
	public abstract class GeometricFigure
	{
		public abstract double GetArea();
		public abstract double GetPerimeter();
	}

	public class Triangle : GeometricFigure
	{
		public override double GetArea()
		{
			double s = (side1 + side2 + side3) / 2;
			return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
		}

		public override double GetPerimeter()
		{
			return side1 + side2 + side3;
		}
		private double side1, side2, side3;

		public Triangle(double s1, double s2, double s3)
		{
			side1 = s1;
			side2 = s2;
			side3 = s3;
		}
	}
	public class Square : GeometricFigure
	{
		private double side;

		public Square(double s)
		{
			side = s;
		}

		public override double GetArea()
		{
			return side * side;
		}

		public override double GetPerimeter()
		{
			return 4 * side;
		}
	}
	public class Romb : GeometricFigure
	{
		private double side, height;

		public Romb(double s, double h)
		{
			side = s;
			height = h;
		}

		public override double GetArea()
		{
			return side * height;
		}

		public override double GetPerimeter()
		{
			return 4 * side;
		}
	}
	public class Rectangle : GeometricFigure
	{
		private double width, height;

		public Rectangle(double w, double h)
		{
			width = w;
			height = h;
		}

		public override double GetArea()
		{
			return width * height;
		}

		public override double GetPerimeter()
		{
			return 2 * (width + height);
		}
	}
	public class Parallelogram : GeometricFigure
	{
		private double baseLength, height, sideLength;

		public Parallelogram(double b, double h, double s)
		{
			baseLength = b;
			height = h;
			sideLength = s;
		}

		public override double GetArea()
		{
			return baseLength * height;
		}

		public override double GetPerimeter()
		{
			return 2 * (baseLength + sideLength);
		}
	}
	public class Trapecia : GeometricFigure
	{
		private double base1, base2, height, side1, side2;

		public Trapecia(double b1, double b2, double h, double s1, double s2)
		{
			base1 = b1;
			base2 = b2;
			height = h;
			side1 = s1;
			side2 = s2;
		}

		public override double GetArea()
		{
			return 0.5 * (base1 + base2) * height;
		}

		public override double GetPerimeter()
		{
			return base1 + base2 + side1 + side2;
		}
	}
	public class Kolo : GeometricFigure
	{
		private double radius;

		public Kolo(double r)
		{
			radius = r;
		}

		public override double GetArea()
		{
			return Math.PI * radius * radius;
		}

		public override double GetPerimeter()
		{
			return 2 * Math.PI * radius;
		}
	}
	public class CompositeFigure
	{
		private GeometricFigure[] figures;

		public CompositeFigure(params GeometricFigure[] figs)
		{
			figures = figs;
		}

		public double GetTotalArea()
		{
			double totalArea = 0;
			foreach (var figure in figures)
			{
				totalArea += figure.GetArea();
			}
			return totalArea;
		}

		public double GetTotalPerimeter()
		{
			double totalPerimeter = 0;
			foreach (var figure in figures)
			{
				totalPerimeter += figure.GetPerimeter();
			}
			return totalPerimeter;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Triangle triangle = new Triangle(3, 4, 5);
			Square square = new Square(4);
			Romb rhombus = new Romb(4, 3);
			Rectangle rectangle = new Rectangle(5, 6);
			Parallelogram parallelogram = new Parallelogram(5, 4, 3);
			Trapecia trapezoid = new Trapecia(3, 4, 5, 3, 4);
			Kolo circle = new Kolo(3);

			CompositeFigure compositeFigure = new CompositeFigure(triangle, square, rhombus, rectangle, parallelogram, trapezoid, circle);

			Console.WriteLine($"Total Area: {compositeFigure.GetTotalArea()}");
			Console.WriteLine($"Total Perimeter: {compositeFigure.GetTotalPerimeter()}");
		}
	}
}
