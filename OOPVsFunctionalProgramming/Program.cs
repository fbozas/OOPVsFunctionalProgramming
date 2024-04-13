using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVsFunctionalProgramming
{
	internal class Program
	{
		static double Area(double radius) 
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		static double Perimeter(double radius) 
		{
			return 2 * Math.PI * radius;
		}

		static void Main(string[] args)
		{
			// Procedural / Functional way
			var radius1 = 10;
            Console.WriteLine("The circles's radius is {0}", radius1);
			Console.WriteLine("The circles's area is {0}", Area(radius1));
			Console.WriteLine("The circles's perimeter is {0}", Perimeter(radius1));
            Console.WriteLine();
            var radius2 = 20;
			Console.WriteLine("The circles's radius is {0}", radius2);
			Console.WriteLine("The circles's area is {0}", Area(radius2));
			Console.WriteLine("The circles's perimeter is {0}", Perimeter(radius2));
			Console.WriteLine();

			// OOP Way
			var circle1 = new Circle();
			circle1.Radius = 1;
			Console.WriteLine("The circles's radius is {0}", circle1.Radius);
			Console.WriteLine("The circles's area is {0}", circle1.Area());
			Console.WriteLine("The circles's perimeter is {0}", circle1.Perimeter());
			Console.WriteLine();

			// Print whole info at once
			var circle2 = new Circle()
			{
				Radius = 1
			};

			Console.WriteLine(circle2.GetSummary());

			Console.WriteLine(circle2.ToString());
			Console.WriteLine(circle2);

			Console.WriteLine();
			// Creating a circle without radius
			var circle3 = new Circle(10);
            Console.WriteLine(circle3.Radius);
            Console.WriteLine(circle3.Perimeter());


        }
	}
}
