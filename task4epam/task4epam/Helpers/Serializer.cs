using System.IO;
using System.Xml.Serialization;

namespace task4epam
{
    static class Serializer
    {
        /// <summary>
        /// This static method creates XML file (if file exists it creates it overwrites it)
        /// </summary>
        /// <typeparam name="T">Type of entity that needs to be serialized</typeparam>
        /// <param name="filePath">Directory with file name to create it</param>
        /// <param name="somethingToSerialize">Entity to serialize</param>
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
