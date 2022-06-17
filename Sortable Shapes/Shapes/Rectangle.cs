namespace Sortable_Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            AreaSize = Width * Height;
        }

        public double Height { get; set; }

        public double Width { get; set; }
    }
}
