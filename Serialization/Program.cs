using System;
using Serialization.Binary;
using Serialization.XML;
using Serialization.JSON;
using System.Collections.Generic;

namespace Serialization
{
    class Program
    {
        static Circle TestCircle1 = new Circle(Color.Red, Color.Blue, 15);
        static Circle TestCircle2 = new Circle(Color.Purple, Color.White, 8);
        static Circle TestCircle3 = new Circle(Color.Blue, Color.Yellow, 19);
        static Circle TestCircle4 = new Circle(Color.Black, Color.Green, 24);
        static void BinSerialization()
        {
            ColorWriteLine("----BinarySerializationObject----", ConsoleColor.Red);
            BinarySerialization.Serialize(TestCircle1, "Binary/"+nameof(TestCircle1));
            Circle CircleDeser = BinarySerialization.Deserialize<Circle>("Binary/TestCircle1.bin");
            Console.WriteLine(CircleDeser.GetInfo()+"\n");

            ColorWriteLine("----BinarySerializationArray----", ConsoleColor.Red);

            Circle[] CircleArray = new Circle[] { TestCircle2, TestCircle3, TestCircle4 };
            BinarySerialization.Serialize(CircleArray, "Binary/" + nameof(CircleArray));
            Circle[] DeserArray = BinarySerialization.Deserialize<Circle[]>("Binary/CircleArray.bin");
            foreach(Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo()+"\n");
            }

            ColorWriteLine("----BinarySerializationList----", ConsoleColor.Red);

            List<Circle> CircleList = new List<Circle>() { TestCircle2, TestCircle3, TestCircle4 };
            BinarySerialization.Serialize(CircleList, "Binary/" + nameof(CircleList));
            List<Circle> DeserList = BinarySerialization.Deserialize<List<Circle>>("Binary/CircleList.bin");
            foreach (Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }
        }
        static void XmlSerialization()
        {
            ColorWriteLine("----XMLSerializationObject----", ConsoleColor.Green);
            XMLSerialization.Serialize<Circle>(TestCircle1, "XML/"+nameof(TestCircle1));
            Circle CircleDeser = XMLSerialization.Deserialize<Circle>("XML/TestCircle1.xml");
            Console.WriteLine(CircleDeser.GetInfo()+"\n");

            ColorWriteLine("----XMLSerializationArray----", ConsoleColor.Green);

            Circle[] CircleXMLArray = new Circle[] { TestCircle2, TestCircle3, TestCircle4 };
            XMLSerialization.Serialize<Circle[]>(CircleXMLArray, "XML/" + nameof(CircleXMLArray));
            Circle[] DeserArray = XMLSerialization.Deserialize<Circle[]>("XML/CircleXMLArray.xml");
            foreach (Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }

            ColorWriteLine("----XMLSerializationList----", ConsoleColor.Green);

            List<Circle> CircleXMLList = new List<Circle>() { TestCircle2, TestCircle3, TestCircle4  };
            XMLSerialization.Serialize<List<Circle>>(CircleXMLList, "XML/" + nameof(CircleXMLList));
            List<Circle> DeserList = XMLSerialization.Deserialize<List<Circle>>("XML/CircleXMLList.xml");
            foreach (Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }
        }
        static void JsonSerialization()
        {
            ColorWriteLine("----JSONSerializationObject----", ConsoleColor.Cyan);
            JSONSerialization.Serialize(TestCircle1, "JSON/"+nameof(TestCircle1));
            Circle CircleDeser = JSONSerialization.Deserialize<Circle>("JSON/TestCircle1.json");
            Console.WriteLine(CircleDeser.GetInfo()+"\n");

            ColorWriteLine("----JSONSerializationArray----", ConsoleColor.Cyan);

            Circle[] CircleJSONArray = new Circle[] { TestCircle2, TestCircle3, TestCircle4 };
            JSONSerialization.Serialize(CircleJSONArray, "JSON/" + nameof(CircleJSONArray));
            Circle[] DeserArray = JSONSerialization.Deserialize<Circle[]>("JSON/CircleJSONArray.json");
            foreach (Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }

            ColorWriteLine("----JSONSerializationList----", ConsoleColor.Cyan);

            List<Circle> CircleJSONList = new List<Circle>() { TestCircle2, TestCircle3, TestCircle4 };
            JSONSerialization.Serialize(CircleJSONList, "JSON/" + nameof(CircleJSONList));
            List<Circle> DeserList = JSONSerialization.Deserialize<List<Circle>>("JSON/CircleJSONList.json");
            foreach (Circle k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }
        }
        static void Main(string[] args)
        {
            BinSerialization();
            XmlSerialization();
            JsonSerialization();
        }
        static void ColorWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
