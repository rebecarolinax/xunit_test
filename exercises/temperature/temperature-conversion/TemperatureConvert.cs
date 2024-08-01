using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_conversion
{
    public class TemperatureConvert
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
    }
}
