using UnityEditor;
using UnityEngine;

namespace HamiIO
{
    public class HamiScriptableObject : Editor
    {
        public static void Create<T>(string relativePath, string fileName) where T : ScriptableObject
        {
            T asset = CreateInstance<T>();
            AssetDatabase.CreateAsset(asset, $"Assets/Resources/{relativePath}/{fileName}.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }
    }
}