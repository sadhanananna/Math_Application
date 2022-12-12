using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Application
{
    /// <summary>
    /// Class for Creating Mock List Of Shapes For Example used in Main class and Unit testing
    /// </summary>
    public static class MockData
    {
        public static List<Shape> CreateMockData()
        {
            List<Shape> Shapes = new List<Shape>();
            //Circle
            Shapes.Add(new Circle(3));
            //Square
            Shapes.Add(new Quadrilateral(3, 3));
            //Recatngle
            Shapes.Add(new Quadrilateral(3, 4));
            //Equilateral Triangle
            Shapes.Add(new Triangle(1, 1, 1));
            //Isosceles Triangle
            Shapes.Add(new Triangle(1, 2, 2));
            //Scalene Triangle
            Shapes.Add(new Triangle(2, 3, 4));

            return Shapes;
        }
    }
}
