using System.IO;
using System.Text.Json;

namespace Serialization.JSON
{
    class JSONSerialization
    {
        public static void Serialize(object obj, string name)
        {
            using (StreamWriter fs = new StreamWriter(name + ".json", false))
            {
                string json = JsonSerializer.Serialize(obj);
                fs.Write(json);
                fs.Flush();
                fs.Close();
            }
        }
        public static T Deserialize<T>(string path)
        {
            using (StreamReader fs = new StreamReader(path))
            {
                string json = fs.ReadToEnd();
                T deserialized = JsonSerializer.Deserialize<T>(json);
                fs.Close();
                return deserialized;
            }
        }
    }
}
