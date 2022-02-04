using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Utility
{
    public static class WeatherUtility
    {

        public static double celsiusToFahrenheit(double celsius){
            double Farenheit = celsius * 1.8 + 32;
            return Farenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit){
            double celsius = 1.8 * (fahrenheit - 32);
            return celsius;
        }


    }
}