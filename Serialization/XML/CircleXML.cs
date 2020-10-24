using System;
using Serialization;

namespace Serialization.XML
{
    [Serializable]
    public class CircleXML
    {
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public double Radius { get; set; }
        public CircleXML(Color fillColor, Color outlineColor, double radius)
        {
            this.FillColor = fillColor;
            this.OutlineColor = outlineColor;
            this.Radius = radius;
        }
        public CircleXML() { }
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
