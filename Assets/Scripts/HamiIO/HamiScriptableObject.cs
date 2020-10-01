using System.IO;
using UnityEditor;
using UnityEngine;

namespace HamiIO
{
    public class HamiScriptableObject : Editor
    {
        public static void Create<T>(string relativePath, string fileName) where T : ScriptableObject
        {
            if (!Directory.Exists($"Assets/Resources/Modules/{relativePath}"))
                Directory.CreateDirectory($"Assets/Resources/Modules/{relativePath}");
            T asset = CreateInstance<T>();
            AssetDatabase.CreateAsset(asset, $"Assets/Resources/Modules/{relativePath}/{fileName}.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }
    }
}