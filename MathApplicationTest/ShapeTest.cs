using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Math_Application;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace MathApplicationTest
{
    /// <summary>
    /// Unit test class for testing all operations on shapes
    /// </summary>
    
    [TestClass]
    public class ShapesTest
    {
        List<Shape> expectedList;
        string path;
        public ShapesTest()
        {
            expectedList = MockData.CreateMockData();
            path= Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        }

        /// <summary>
        /// Testcase for validating Sorting shapes by Area
        /// </summary>
        [TestMethod]
        public void PerformUnitTestForSortingShapesByArea()
        {
            var actualList = expectedList;
            expectedList.Sort((x, y) => y.Area.CompareTo(x.Area));

            SortByArea area = new SortByArea();
            actualList = area.SortShapesByArea(actualList);

            Assert.AreEqual(actualList,expectedList);

        }

        /// <summary>
        /// Testcase for validating Sorting shapes by Perimeter
        /// </summary>
        [TestMethod]
        public void PerformUnitTestForSortingShapesByPerimeter()
        {
            var actualList = expectedList;
            expectedList.Sort((x, y) => y.Perimeter.CompareTo(x.Perimeter));

            SortByPerimeter perimeter = new SortByPerimeter();
            actualList =perimeter.SortShapesByPerimeter(actualList);

            Assert.AreEqual(actualList,expectedList);

        }

        /// <summary>
        /// Testcase for validating Conversion of shapes Objects to JSON Data
        /// </summary>
        [TestMethod]
        public void PerformUnitTestForJSONData()
        {
            string expectedJSON= File.ReadAllText(path+"\\MockJSONData.json");
            SerializeJSON jsonObject = new SerializeJSON();
            string actualJSON = jsonObject.ConvertObjectToJSON(expectedList);
            Assert.AreEqual(expectedJSON, actualJSON);
        }

        /// <summary>
        /// Testcase for validating Conversion of shapes Objects to XML Data
        /// </summary>
        [TestMethod]
        public void PerformUnitTestForXMLData()
        {
            string expectedXML = File.ReadAllText(path + "\\MockXMLData.xml");
            SerializeXML xmlObject = new SerializeXML();
            string actualXML = xmlObject.ConvertObjectToXML(expectedList);
            Assert.AreEqual(expectedXML,actualXML);
        }

        /// <summary>
        /// Testcase for validating tracking of instances created for Shape object per class.
        /// </summary>
        [TestMethod]
        public void PerformUnitTestForObjectTracking()
        {
            //Instances created for Shape Object are stored in Dictionary
            Assert.IsTrue(ObjectTracker.ObjectDic["Shape"]>0);
        }
    }
}