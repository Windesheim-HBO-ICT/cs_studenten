using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public struct Temperature
    {
        private readonly double? maximum;
        private readonly double? minimum;
        private readonly double? value;

        public double? Minimum => minimum;
        public double? Maximum => maximum;
        public double? Value => value;

        public Temperature(int minimum, int maximum): this(ConvertMinMaxToValue(minimum, maximum), minimum, maximum) {}

        public Temperature(int value):this(value, ConvertValueToMinOrMax(value), ConvertValueToMinOrMax(value)) {}

        public Temperature(int value, int minimum, int maximum) 
        {
            this.value = value;
            this.minimum = minimum;
            this.maximum = maximum;
        }

        public static int ConvertMinMaxToValue(int minimum, int maximum)
        {
            return (minimum + maximum) / 2;
        }
        public static int ConvertValueToMinOrMax(int value) 
        {
            return value;
        }
    }
}
