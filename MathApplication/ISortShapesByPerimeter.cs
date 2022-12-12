using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    /// <summary>
    /// Interface for Sorting Shapes By Perimeter
    /// </summary>
    interface ISortShapesByPerimeter
    {
        List<Shape> SortShapesByPerimeter(List<Shape> Shapes);
    }
}
