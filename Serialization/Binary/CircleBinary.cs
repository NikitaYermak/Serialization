using System;
using System.Collections.Generic;
using System.Text;
using Serialization;

namespace Serialization.Binary
{
    [Serializable]
    class CircleBinary
    {
        private Color FillColor { get; set; }
        private Color OutlineColor { get; set; }
        private double Radius { get; set; }
        public CircleBinary(Color fillColor, Color outlineColor, double radius)
        {
            this.FillColor = fillColor;
            this.OutlineColor = outlineColor;
            this.Radius = radius;
        }
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
