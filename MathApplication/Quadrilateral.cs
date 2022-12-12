using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Application
{
    /// <summary>
    /// Class for Square/Rectangle shape objects
    /// </summary>
    public class Quadrilateral : Shape
    {
        [XmlElement(ElementName = "Height")]
        public double Height { get; set; }

        [XmlElement(ElementName = "Width")]
        public double Width { get; set; }

        public Quadrilateral() { }
        public Quadrilateral(double _Height, double _Width)
        {
            Height = _Height;
            Width = _Width;
            CalculateArea();
            CalculatePerimeter();
            CheckShape();
        }

        public override void CalculateArea()
        {
            Area = Height * Width;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = Height * 2 + Width * 2;
        }

        public override void CheckShape()
        {

            if (Height == Width)
            {
                ObjectShape = "square";
            }
            else
            {
                ObjectShape = "rectangle";
            }
        }
    }
}
