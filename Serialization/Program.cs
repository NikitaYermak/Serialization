using System;
using Serialization.Binary;
using Serialization.XML;
using System.Collections.Generic;

namespace Serialization
{
    class Program
    {
        static void BinSerialization()
        {
            CircleBinary TestCircle1 = new CircleBinary(Color.Red, Color.Blue, 15);
            CircleBinary TestCircle2 = new CircleBinary(Color.Purple, Color.White, 8);
            CircleBinary TestCircle3 = new CircleBinary(Color.Blue, Color.Yellow, 19);
            CircleBinary TestCircle4 = new CircleBinary(Color.Black, Color.Green, 24);
            Console.WriteLine("----BinarySerialization----");
            BinarySerialization.Serialize(TestCircle1, nameof(TestCircle1));
            CircleBinary CircleDeser = (CircleBinary)BinarySerialization.Deserialize("TestCircle1.bin");
            Console.WriteLine(CircleDeser.GetInfo());

            Console.WriteLine("-------------------------------------------------");

            CircleBinary[] CircleBinaryArray = new CircleBinary[] { TestCircle2, TestCircle3, TestCircle4 };
            BinarySerialization.Serialize(CircleBinaryArray, nameof(CircleBinaryArray));
            CircleBinary[] DeserArray = (CircleBinary[])BinarySerialization.Deserialize("CircleBinaryArray.bin");
            foreach(CircleBinary k in DeserArray)
            {
                Console.WriteLine(k.GetInfo()+"\n");
            }

            Console.WriteLine("-------------------------------------------------");

            List<CircleBinary> CircleBinaryList = new List<CircleBinary>() { TestCircle2, TestCircle3, TestCircle4 };
            BinarySerialization.Serialize(CircleBinaryList, nameof(CircleBinaryList));
            List<CircleBinary> DeserList = (List<CircleBinary>)BinarySerialization.Deserialize("CircleBinaryList.bin");
            foreach (CircleBinary k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }
            Console.WriteLine("-------------------------------------------------\n");
        }
        static void XmlSerialization()
        {
            CircleXML TestCircle5 = new CircleXML(Color.Red, Color.Blue, 15);
            CircleXML TestCircle6 = new CircleXML(Color.Purple, Color.White, 8);
            CircleXML TestCircle7 = new CircleXML(Color.Blue, Color.Yellow, 19);
            CircleXML TestCircle8 = new CircleXML(Color.Black, Color.Green, 24);
            Console.WriteLine("----XMLSerialization----");
            XMLSerialization.Serialize<CircleXML>(TestCircle5, nameof(TestCircle5));
            CircleXML CircleDeser = (CircleXML)XMLSerialization.Deserialize<CircleXML>("TestCircle5.xml");
            Console.WriteLine(CircleDeser.GetInfo());

            Console.WriteLine("-------------------------------------------------");

            CircleXML[] CircleXMLArray = new CircleXML[] { TestCircle6, TestCircle7, TestCircle8 };
            XMLSerialization.Serialize<CircleXML[]>(CircleXMLArray, nameof(CircleXMLArray));
            CircleXML[] DeserArray = (CircleXML[])XMLSerialization.Deserialize<CircleXML[]>("CircleXMLArray.xml");
            foreach (CircleXML k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }

            Console.WriteLine("-------------------------------------------------");

            List<CircleXML> CircleXMLList = new List<CircleXML>() { TestCircle6, TestCircle7, TestCircle8 };
            XMLSerialization.Serialize<List<CircleXML>>(CircleXMLList, nameof(CircleXMLList));
            List<CircleXML> DeserList = (List<CircleXML>)XMLSerialization.Deserialize<List<CircleXML>>("CircleXMLList.xml");
            foreach (CircleXML k in DeserArray)
            {
                Console.WriteLine(k.GetInfo() + "\n");
            }
            Console.WriteLine("-------------------------------------------------");
        }
        static void Main(string[] args)
        {
            BinSerialization();
            XmlSerialization();
        }
    }
}
