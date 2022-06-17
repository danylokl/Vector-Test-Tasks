namespace Sortable_Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            AreaSize = Radius * Radius * System.Math.PI;
        }
    }
}
