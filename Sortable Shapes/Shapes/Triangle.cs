namespace Sortable_Shapes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double height,double _base)
        {
            Base = _base;
            Height = height;
            AreaSize = (Base * Height) / 2;
        }
    }
}
