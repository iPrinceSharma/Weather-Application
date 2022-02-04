using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models
{
    public class Location
    {
        String Name { get; set; }
        String Country { get; set; }
        String Region { get; set; }
        String Lat { get; set; }
        String Lon { get; set; }
        String TimezoneId { get; set; }

        CurrentWeather mCurrentWeather { get; set; }
    }
}