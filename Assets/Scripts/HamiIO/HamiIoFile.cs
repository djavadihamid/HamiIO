using System.IO;

namespace HamiIO
{
    public class HamiIoFile
    {
        public static void DeleteAllFiles(string folder)
        {
            if(!Directory.Exists(CONSTS.__FULL_PATH_TO_RESOURCES + folder)) return;
            DirectoryInfo di = new DirectoryInfo(CONSTS.__FULL_PATH_TO_RESOURCES + folder);
            foreach (FileInfo file in di.GetFiles()) file.Delete();
        }
    }
}