using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Math_Application
{
    /// <summary>
    /// Class for Converting Shape Objects to XML
    /// </summary>
    public class SerializeXML : ISerializeXML
    {
        public string ConvertObjectToXML(List<Shape> Shapes)
        {
            string xmlString = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shape>));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                    xmlSerializer.Serialize(memoryStream, Shapes);
                    memoryStream.Position = 0;
                    xmlString = new StreamReader(memoryStream).ReadToEnd();
            }
            return xmlString;
        }
    }
}
