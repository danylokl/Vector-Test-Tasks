using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortable_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = 5;
            double radius = 4;
            double Base = 5;
            double height = 2;
            double width = 6;
            var shapes = new List<Shape>
            {
                new Square(side),
                new Circle(radius),
                new Triangle(height, Base),
                new Rectangle(width, height)
            };

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
