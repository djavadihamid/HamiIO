using System.IO;
using UnityEngine;

namespace HamiIO
{
    public class HamiModuleEnum
    {
        public static void Write(string folderPath, string fileName, string[] items)
        {
            string basePath = CONSTS.__FULL_PATH_TO_RESOURCES;
            string completePath = $"{basePath}\\{folderPath}\\{fileName}.cs";
            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
            if (!File.Exists(completePath)) File.Create(completePath).Close();
            File.WriteAllText(completePath, $"public enum {fileName}\n{{\n\t {string.Join(",\n\t", items)} \n}}");

            MonoBehaviour.print($"Enum has been created in {completePath}");
        }
    }
}