using System;
using Serialization;
using System.Runtime.Serialization;

namespace Serialization.XML
{
    [Serializable]
    public class Circle : ISerializable
    {
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public double Radius { get; set; }
        public Circle(Color fillColor, Color outlineColor, double radius)
        {
            this.FillColor = fillColor;
            this.OutlineColor = outlineColor;
            this.Radius = radius;
        }
        public Circle(SerializationInfo info, StreamingContext context)
        {
            this.FillColor = (Color)info.GetValue("FillColor", typeof(Color));
            this.OutlineColor = (Color)info.GetValue("OutlineColor", typeof(Color));
            this.Radius = (double)info.GetValue("Radius", typeof(double));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FillColor", this.FillColor);
            info.AddValue("OutlineColor", this.OutlineColor);
            info.AddValue("Radius", this.Radius);
            info.AddValue("Area", this.Area());
            info.AddValue("Length", this.Length());
        }
        public Circle() { }
        public float Area()
        {
            return (float)(3.1415 * Math.Pow(Radius, 2));
        }
        public float Length()
        {
            return (float)(2f * 3.1415 * Radius);
        }
        public string GetInfo()
        {
            string result = $"Fill color: {FillColor};\nOutline color: {OutlineColor};\nРадиус: {Radius};\nArea: {Area()};\nLenght: {Length()};";
            return result;
        }
    }
}
