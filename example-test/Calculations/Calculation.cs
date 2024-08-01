using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class Calculation
    {
        public static double Add(double x, double y )
        {
            return (x + y);
        }

        public static double Sub(double x, double y)
        {
            return (x - y);
        }
        public static double Multiplication(double x, double y)
        {
            return (x * y);
        }
        public static double Divide(double x, double y)
        {
            return (x / y);
        }  
        public static double Module(double x, double y)
        {
            return (x % y);
        }
    }
}
