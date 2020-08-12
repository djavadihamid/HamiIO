using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace HamiIO
{
    public class HamiModuleJsonConfig
    {
        public static void Write<T>(string folderPath, string fileName, T obj)
        {
            FileChecker.CheckJson(folderPath, fileName);
            File.WriteAllText($@"{CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}.json",
                              JsonConvert.SerializeObject(obj, Formatting.Indented)
                             );
            MonoBehaviour.print($@"Json has been created in {CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}");
        }
    }
}