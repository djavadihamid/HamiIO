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
            string nameSpace = null
        )
        {
            FileChecker.HasCs(folderPath + @"\Model", fileName, true);
            string content = "";
            if (!string.IsNullOrEmpty(nameSpace)) content += $"namespace {nameSpace}{{ \n";
            content += $"public class {fileName}{{\n\n";
            foreach (PropertiesModel modelPropertiese in properties)
            {
                content += string.IsNullOrEmpty(modelPropertiese.Attribute)
                    ? null
                    : $"\t[{modelPropertiese.Attribute}]\n";
                content += $"\tpublic {modelPropertiese.Type} {modelPropertiese.Name};\n\n";
            }

            content += string.IsNullOrEmpty(nameSpace) ? "}" : "}\n}";
            FileChecker.HasCs(folderPath + @"\Model", fileName, true);
            File.WriteAllText($@"{CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\Model\{fileName}.cs", content);
            MonoBehaviour.print(
                $@"CS has been created in {CONSTS.__FULL_PATH_TO_RESOURCES}{folderPath}\Model\{fileName}");
        }
    }
}