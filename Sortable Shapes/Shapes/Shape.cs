using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
