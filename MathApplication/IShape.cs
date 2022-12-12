using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    /// <summary>
    /// Interface for implementing multiple inheritance for Shape Object
    /// </summary>
    interface IShape : ICalculateArea, ICalculatePerimeter, ICheckShape
    {
    }
}
