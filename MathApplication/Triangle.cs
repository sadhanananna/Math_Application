using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Application
{
    /// <summary>
    /// Class for Triangle Shape Objects which inherits Shape class
    /// </summary>
    public class Triangle : Shape
    {
        [XmlElement(ElementName = "Side1")]
        public double Side1 { get; set; }

        [XmlElement(ElementName = "Side2")]
        public double Side2 { get; set; }

        [XmlElement(ElementName = "Side3")]
        public double Side3 { get; set; }

        public Triangle() { }
        public Triangle(double _Side1, double _Side2, double _Side3)
        {
            Side1 = _Side1;
            Side2 = _Side2;
            Side3 = _Side3;
            CalculateArea();
            CalculatePerimeter();
            CheckShape();
        }
        public override void CalculateArea()
        {
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));

        }

        public override void CalculatePerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }

        public override void CheckShape()
        {
            if (Side1 == Side2 && Side2 == Side3)
                ObjectShape = "Equilateral Triangle";

            // Check for isosceles triangle
            else if (Side1 == Side2 || Side2 == Side3 || Side3 == Side1)
                ObjectShape = "Isosceles Triangle";

            // Otherwise scalene triangle
            else
                ObjectShape = "Scalene Triangle";
        }
    }
}
