namespace Sortable_Shapes
{
   public class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
          Side = side;
          AreaSize = Side * Side;
        }
       
    }
}
