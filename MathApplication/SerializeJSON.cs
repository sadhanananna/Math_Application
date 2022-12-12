using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Math_Application
{
    /// <summary>
    /// Class for Converting Shape Objects to JSON
    /// </summary>
    public class SerializeJSON : ISerializeJSON
    {
        public string ConvertObjectToJSON(List<Shape> Shapes)
        {
            return JsonConvert.SerializeObject(Shapes);
        }
    }
}
