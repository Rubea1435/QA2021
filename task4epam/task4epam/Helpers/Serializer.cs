using System.IO;
using System.Xml.Serialization;

namespace task4epam
{
    static class Serializer
    {
        public static void CreateXml<T>(string filePath, T somethingToSerialize)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, somethingToSerialize);
            }
        }
    }
}
