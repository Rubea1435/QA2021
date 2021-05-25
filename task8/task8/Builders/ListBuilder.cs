using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace task8
{
    class ListBuilder<T>
    {
        public List<T> Create(string filePath)
        {
            List<T> resultList = new List<T>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                resultList = (List<T>)formatter.Deserialize(fs);
            }
            return resultList;
        }
    }
}
