using System.IO;
using System.Xml.Serialization;

namespace HamiIO
{
    public class HamiModuleXmlIO
    {
        public static T Read<T>(string fileName) where T : class
        {
            if (!File.Exists($"{CONSTS.__PROJECT_PATH_IN_RESOURCES}{fileName}.xml"))
                return null;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return xmlSerializer.Deserialize(
                new StringReader(File.ReadAllText($"{CONSTS.__PROJECT_PATH_IN_RESOURCES}{fileName}.xml"))) as T;
        }

        public static void Write<T>(string fileName, T toSerialize)
        {
            if (!Directory.Exists(CONSTS.__PROJECT_PATH_IN_RESOURCES))
                Directory.CreateDirectory(CONSTS.__PROJECT_PATH_IN_RESOURCES);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            var write = new StreamWriter($"{CONSTS.__PROJECT_PATH_IN_RESOURCES}{fileName}.xml");
            xmlSerializer.Serialize(write.BaseStream, toSerialize);
            write.Close();
        }
        
    }
}