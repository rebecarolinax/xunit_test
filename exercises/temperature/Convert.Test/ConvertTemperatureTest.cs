using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using temperature_conversion;

namespace Convert.Test
{
    public class ConvertTemperatureTest
    {
        [Theory]
        [InlineData(0, 32)] // 0°C é igual a 32°F
        [InlineData(100, 212)] // 100°C é igual a 212°F
        public void ConvertTestOK(double celsius, double fahrenheitExpected)
        {


            double fahrenheit = TemperatureConvert.CelsiusToFahrenheit(celsius);

            Assert.Equal(fahrenheitExpected, fahrenheit, 2); // Usamos 2 casas decimais para a comparação
        }
    }
}
