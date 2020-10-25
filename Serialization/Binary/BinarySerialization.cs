using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization.Binary
{
    public static class BinarySerialization
    {
        public static void Serialize(object obj, string name)
        {
            using (FileStream fs = new FileStream(name+".bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
                fs.Flush();
                fs.Close();
            }
        }
        public static T Deserialize<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                T deserialized = (T)bf.Deserialize(fs);
                fs.Close();
                return deserialized;
            }
        }
    }
}
