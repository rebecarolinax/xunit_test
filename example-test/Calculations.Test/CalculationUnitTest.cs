using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class CalculationUnitTest
    {
        [Fact]
        public void AddTwoNumbers()
        {
            var n1 = 3.3;
            var n2 = 2.2;

            var expectedValue = 5.5;

            var add = Calculation.Add(n1,n2);

            Assert.Equal(expectedValue, add);
        }

        [Fact]
        public void SubTwoNumbers()
        {
            var n1 = 3.0;
            var n2 = 2.0;

            var expectedValue = 1.0;

            var sub = Calculation.Sub(n1, n2);

            Assert.Equal(expectedValue, sub);
        }

        [Fact]
        public void MultiplicationTwoNumbers()
        {
            var n1 = 3.0;
            var n2 = 2.0;

            var expectedValue = 6.0;

            var mult = Calculation.Multiplication(n1, n2);

            Assert.Equal(expectedValue, mult);
        }

        [Fact]
        public void DivideTwoNumbers()
        {
            var n1 = 10.0;
            var n2 = 2.0;

            var expectedValue = 5.0;

            var div = Calculation.Divide(n1, n2);

            Assert.Equal(expectedValue, div);
        }

        [Fact]
        public void ModuleTwoNumbers()
        {
            var n1 = 10.0;
            var n2 = 100.0;

            var expectedValue = 10.0;

            var mod = Calculation.Module(n1, n2);

            Assert.Equal(expectedValue, mod);
        }
    }
}
