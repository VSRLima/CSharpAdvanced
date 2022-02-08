using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }

    public class ConversorInstance
    {
        public static double temperatura;
        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }

        public double FahToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }
}