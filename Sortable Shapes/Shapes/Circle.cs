namespace Sortable_Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
            AreaSize = Radius * Radius * System.Math.PI;
        }

        public double Radius { get; set; }
    }
}
