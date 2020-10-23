using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
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
        public static object Deserialize(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object deserialized = (object)bf.Deserialize(fs);
                fs.Close();
                return deserialized;
            }
        }
    }
}
