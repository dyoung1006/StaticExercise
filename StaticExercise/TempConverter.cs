using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double farenheit) => (farenheit - 32) / 1.8;

        public static double CelsiusToFahrenheit(double celsius) => (celsius * 9) / 5 + 32;
    }
}
