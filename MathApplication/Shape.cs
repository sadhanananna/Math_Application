using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Application
{
	/// <summary>
	/// Shape Object class which is parent class for all shapes like circle,quadrilateral,triangle.
	/// </summary>
	
	[XmlInclude(typeof(Circle))]
	[XmlInclude(typeof(Quadrilateral))]
	[XmlInclude(typeof(Triangle))]
	public abstract class Shape: IShape
    {
		public Shape()
		{
			ObjectTracker.ObjectTrackerPerClass("Shape");
		}

		[XmlElement(ElementName = "ObjectShape")]
		public string ObjectShape { get; set; }
        
		[XmlElement(ElementName = "Area")]
		public double Area { get; set; }

		[XmlElement(ElementName = "Perimeter")]
		public double Perimeter { get; set; }
		public abstract void CalculateArea();
		public abstract void CalculatePerimeter();
		public abstract void CheckShape();
	}
}
