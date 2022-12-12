using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    /// <summary>
    /// Interface for Saving Data in Different Formats on Disk
    /// </summary>
    interface ISaveDataToLocalFile
    {
        void SaveDataToFile(string path, string type, string data);
    }
}
