using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace HamiIO
{
    public class HamiModuleJsonConfig
    {
        public static void Write<T>(string folderPath, string fileName, T obj)
        {
            FileChecker.HasJson(folderPath, $"{fileName}JSON", true);
            File.WriteAllText($@"{CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}JSON.json",
                              JsonConvert.SerializeObject(obj, Formatting.Indented)
                             );
            MonoBehaviour.print($@"Json has been created in {CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}JSON");
        }

        public static string Read(string folderPath, string fileName)
        {
            if (!FileChecker.HasJson(folderPath, $"{fileName}JSON")) return null;
            return File.ReadAllText($@"{CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}JSON.json");
        }
    }
}