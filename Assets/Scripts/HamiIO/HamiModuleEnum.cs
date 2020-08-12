using System.IO;
using UnityEngine;

namespace HamiIO
{
    public class HamiModuleEnum
    {
        public static void Write(string folderPath, string fileName, string[] items)
        {
            string basePath     = CONSTS.__FULL_PATH_TO_RESOURCES + folderPath;
            string completePath = $"{basePath}\\{fileName}ENUM.cs";
            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
            if (!File.Exists(completePath)) File.Create(completePath).Close();
            File.WriteAllText(completePath, $"public enum {fileName}ENUM\n{{\n\t {string.Join(",\n\t", items)} \n}}");

            MonoBehaviour.print($"Enum has been created in {completePath}");
        }

        public static bool Has(string folderName, string fileName)
        {
            return File.Exists($"{CONSTS.__FULL_PATH_TO_RESOURCES}{folderName}\\{fileName}ENUM.cs");
        }
    }
}