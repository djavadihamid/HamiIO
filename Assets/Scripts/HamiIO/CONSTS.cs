using UnityEngine;

namespace HamiIO
{
    public class CONSTS
    {
        public static readonly string __PATH_WITHIN_RESOURCES = $"Modules\\";

        public static readonly string __FULL_PATH_TO_RESOURCES =
            $"{Application.dataPath}\\Resources\\{__PATH_WITHIN_RESOURCES}";
    }
}