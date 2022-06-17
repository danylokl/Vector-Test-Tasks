using System;

namespace Sortable_Shapes
{
    public abstract class Shape : IComparable
    {
        public double AreaSize { get; set; }

        public int CompareTo(object obj)
        {
            Shape shape = obj as Shape;
            return this.AreaSize.CompareTo(shape.AreaSize);
        }
    }
}
