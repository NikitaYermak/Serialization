using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization.XML
{
    class XMLSerialization
    {
        public static void Serialize<T>(object obj, string name)
        {
            using (FileStream fs = new FileStream(name + ".xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer bf = new XmlSerializer(typeof(T));
                bf.Serialize(fs, obj);
                fs.Flush();
                fs.Close();
            }
        }
        public static object Deserialize<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer bf = new XmlSerializer(typeof(T));
                T deserialized = (T)bf.Deserialize(fs);
                fs.Close();
                return deserialized;
            }
        }
    }
}
