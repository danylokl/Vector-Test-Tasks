namespace Sortable_Shapes
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
            AreaSize = Side * Side;
        }

        public double Side { get; set; }
    }
}
