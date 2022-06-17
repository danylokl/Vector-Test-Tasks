using System;
using System.Collections.Generic;
using System.Linq;
namespace Sortable_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            double Side = 5;
            double Radius = 4;
            double Base = 5;
            double Height = 2;
            double Width = 6;
            var shapes = new List<Shape> { new Square(Side),
                                           new Circle(Radius),
                                           new Triangle(Height,Base),
                                           new Rectangle(Width,Height)};

            Console.Write("Shapes before sort: ");
            foreach (var shape in shapes)
            {
                Console.Write($"{shape.AreaSize}, ");
            }

            shapes.Sort();

            Console.Write("\nShapes after sort: ");
            foreach (var shape in shapes)
            {
                Console.Write($" {shape.AreaSize}, ");
            }
        }
    }
}
