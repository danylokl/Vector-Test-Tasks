namespace Sortable_Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double _base)
        {
            Base = _base;
            Height = height;
            AreaSize = (Base * Height) / 2;
        }

        public double Base { get; set; }

        public double Height { get; set; }
    }
}
