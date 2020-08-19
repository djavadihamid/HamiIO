using System.IO;
using HamiIO.Cs;
using UnityEngine;

namespace HamiIO
{
    public class HamiIoCs
    {
        public static void WriteModel(string folderPath,
            string fileName,
            PropertiesModel[] properties,
            string nameSpace = null,
            string parent = null
        )
        {
            FileChecker.HasCs(folderPath, fileName, true);
            string content = "";
            AddAndBreak(ref content, new[]
            {
                $"namespace {nameSpace}{{",
                $"public class {fileName}{{",
            });

            foreach (PropertiesModel modelPropertiese in properties)
            {
                AddAndBreak(ref content, new[]
                {
                    modelPropertiese.Attribute,
                    $"public {modelPropertiese.Type} {modelPropertiese.Name};"
                });
            }

            File.WriteAllText($@"{CONSTS.__FULL_PATH_TO_RESOURCES}Model\{folderPath}\{fileName}.cs", content);
            MonoBehaviour.print($@"CS has been created in {CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\{fileName}");
        }

        private static void AddAndBreak(ref string reference, string[] toAdd)
        {
            foreach (string s in toAdd)
            {
                if (string.IsNullOrEmpty(s)) return;
                reference += s + "\n";
            }
        }
    }
}