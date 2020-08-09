using UnityEngine;

namespace HamiModuleXmlIO
{
    public class CONSTS
    {
        public static readonly string __PROJECT_PATH_IN_RESOURCES =
            $"{Application.dataPath}\\Resources\\Modules\\{ProjectName()}\\";

        public static string ProjectName()
        {
            string[] s = Application.dataPath.Split('/');
            return s[s.Length - 2];
        }
    }
}