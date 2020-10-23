using System;
using Serialization.Binary;
using System.Collections.Generic;

namespace Serialization
{
    class Program
    {
        static CircleBinary TestCircle1 = new CircleBinary(Color.Red, Color.Blue, 15);
        static CircleBinary TestCircle2 = new CircleBinary(Color.Purple, Color.White, 8);
        static CircleBinary TestCircle3 = new CircleBinary(Color.Blue, Color.Yellow, 19);
        static CircleBinary TestCircle4 = new CircleBinary(Color.Black, Color.Green, 24);
        static void BinSerialization()
        {
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
            Console.WriteLine("-------------------------------------------------");
        }
        static void Main(string[] args)
        {
            BinSerialization();
        }
    }
}
