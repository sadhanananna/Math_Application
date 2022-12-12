using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Math_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Considering MockData Example
            List<Shape> shapes = MockData.CreateMockData();

            //Sort Shapes by Area
            SortByArea area = new SortByArea();
            List<Shape> sortedAreaList = area.SortShapesByArea(shapes);

            Console.WriteLine("--- Shapes sorted by Area ---");
            foreach (var shape in sortedAreaList)
            {
                Console.WriteLine(shape.ObjectShape + " " + shape.Area.ToString());
            }

            //Sort Shapes by Perimeter
            SortByPerimeter perimeter = new SortByPerimeter();
            List<Shape> sortedPerimeterList = perimeter.SortShapesByPerimeter(shapes);

            Console.WriteLine("");
            Console.WriteLine("--- Shapes sorted by Perimeter ---");
            foreach (var shape in sortedPerimeterList)
            {
                Console.WriteLine(shape.ObjectShape + " " + shape.Perimeter.ToString());

            }

            //Save Shapes in JSON Format
            Console.WriteLine("");
            Console.WriteLine("Enter the path to store Shapes in Json data format");
            string path = Console.ReadLine();
            SaveDataToLocalFile saveData = new SaveDataToLocalFile();
            SerializeJSON jsonObject = new SerializeJSON();
            saveData.SaveDataToFile(path, "\\shapes.json", jsonObject.ConvertObjectToJSON(shapes));

            //Save Shapes in XML Format
            Console.WriteLine("");
            Console.WriteLine("Enter the path to store Shapes in XML data format");
            path = Console.ReadLine();
            SerializeXML xmlObject = new SerializeXML();
            saveData.SaveDataToFile(path, "\\shapes.xml", xmlObject.ConvertObjectToXML(shapes));

            //To Track the Objects per class
            Console.WriteLine("");
            Console.WriteLine("Shape Instances created per class");
            foreach(var obj in ObjectTracker.ObjectDic)
            {
                Console.WriteLine(obj.Key+" "+obj.Value);
            }
        }

    }
}
