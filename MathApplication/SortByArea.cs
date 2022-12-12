using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    /// <summary>
    /// Class for Sorting Shapes By Area
    /// </summary>
    public class SortByArea : ISortShapesByArea
    {
        public List<Shape> SortShapesByArea(List<Shape> Shapes)
        {
            Shapes.Sort((x, y) => y.Area.CompareTo(x.Area));
            return Shapes;
        }
    }
}
