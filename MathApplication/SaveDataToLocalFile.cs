using System.IO;

namespace Math_Application
{
    /// <summary>
    /// Class for Storing Data to Local File on Disk
    /// </summary>
    public class SaveDataToLocalFile : ISaveDataToLocalFile
    {
        public void SaveDataToFile(string path, string fileExtension, string data)
        {
            File.WriteAllText(path + fileExtension, data);
        }
    }
}
