using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
   /// <summary>
   /// Class for tracking Shape Object instances created.
   /// </summary>
    public static class ObjectTracker
    {
        /// <summary>
        /// Dictionary Object storing instances created for Shape Object
        /// </summary>
        public static Dictionary<string, int> ObjectDic = new Dictionary<string, int>();

        /// <summary>
        /// Method incrementing the count of instances for Shape Object
        /// </summary>
        /// <param name="shape"></param>
        public static void ObjectTrackerPerClass(string shape)
        {
            if (ObjectDic.ContainsKey(shape))
            {
                ObjectDic[shape]++;
            }
            else
            {
                ObjectDic.Add(shape, 1);
            }
        }
    }
}
