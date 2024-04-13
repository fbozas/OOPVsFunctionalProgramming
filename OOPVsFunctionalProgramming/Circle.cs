using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVsFunctionalProgramming
{
	internal class Circle
	{
		public double Radius { get; set; }

		public double Area() 
		{ 
			return Math.PI * Math.Pow(Radius, 2);
		}

		public double Perimeter() 
		{
			return 2 * Math.PI * Radius;
		}

		public Circle() { }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public string GetSummary() 
		{
			return "The circles's radius is "+ Radius +
			" The circles's area is " +  Area() +
			" The circles's perimeter is " + Perimeter();
		}

		public override string ToString()
		{
			return "The circles's radius is " + Radius +
			" The circles's area is " + Area() +
			" The circles's perimeter is " + Perimeter();
		}
	}
}
