using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {TempConverter.FahrenheitToCelsius(68)}");
            Console.WriteLine($"fahrenheit {TempConverter.CelsiusToFahrenheit(20)}");
            Console.ReadLine();
        }
    }
}
