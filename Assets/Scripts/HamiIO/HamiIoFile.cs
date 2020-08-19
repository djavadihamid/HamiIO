using System.IO;

namespace HamiIO
{
    public class HamiIoFile
    {
        public static void DeleteAllFiles(string folder)
        {
            DirectoryInfo di = new DirectoryInfo(CONSTS.__FULL_PATH_TO_RESOURCES + folder);
            foreach (FileInfo file in di.GetFiles()) file.Delete();
        }
    }
}