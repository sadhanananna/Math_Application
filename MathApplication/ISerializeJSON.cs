using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    /// <summary>
    /// Interface for Converting Shape Objects to JSON
    /// </summary>
    interface ISerializeJSON
    {
        string ConvertObjectToJSON(List<Shape> Shapes);
    }
}
