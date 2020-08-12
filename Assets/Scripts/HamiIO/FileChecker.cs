using System.IO;

namespace HamiIO
{
    internal class FileChecker
    {
        public static void CheckJson(string folderPath, string fileName)
        {
            Check(folderPath, fileName, "json");
        }

        public static void CheckXml(string folderPath, string fileName)
        {
            Check(folderPath, fileName, "xml");
        }

        public static void CheckCs(string folderPath, string fileName)
        {
            Check(folderPath, fileName, "cs");
        }

        private static void Check(string folderPath, string fileName, string fileExtension)
        {
            string basePath     = CONSTS.__FULL_PATH_TO_RESOURCES + folderPath;
            string completePath = $"{basePath}\\{fileName}.{fileExtension}";
            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
            if (!File.Exists(completePath)) File.Create(completePath).Close();
        }
    }
}