using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Application
{
    /// <summary>
    /// Class for Circular Objects which inherits Shape class
    /// </summary>
    public class Circle : Shape
    {
        [XmlElement(ElementName = "Radius")]
        public double Radius { get; set; }

        public Circle(){}
        public Circle(double _Radius)
        {
            Radius = _Radius;
            CalculateArea();
            CalculatePerimeter();
            CheckShape();
        }
        public override void CalculateArea()
        {
            Area = 3.14 * Radius * Radius;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * 3.14 * Radius;
        }

        public override void CheckShape()
        {
            ObjectShape = "circle";
        }
    }
}
