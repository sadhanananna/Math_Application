using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
	/// <summary>
	/// Class for Sorting Shapes By Perimeter
	/// </summary>
	public class SortByPerimeter : ISortShapesByPerimeter
	{
		public List<Shape> SortShapesByPerimeter(List<Shape> Shapes)
		{
			Shapes.Sort((x, y) => y.Perimeter.CompareTo(x.Perimeter));
			return Shapes;
		}
	}
}
