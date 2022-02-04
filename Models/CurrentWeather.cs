using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models
{
    public class CurrentWeather
    {
        String ObservationTime { get; set; }
        String Temperature { get; set; }
        int WeatherCode { get; set; }
        String WeatherIcon { get; set; }
        String WeatherDescription { get; set; }
        String WindSpeed { get; set; }
        String WindDegree { get; set; }
        String WindDir { get; set; }
        String Pressure { get; set; }
        String Precip { get; set; }
        String Humidity { get; set; }
        String CloudCover { get; set; }
        String FeelsLike { get; set; }
        String UVIndex { get; set; }
        String Visibility { get; set; }
        String IsDay { get; set; }
    }
}