using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WeatherApplication.Models;
using WeatherApplication.Utility;

namespace WeatherApplication.Controllers
{
    [RoutePrefix("Weather")]
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Detail")]
        public ActionResult Detail(){
            // get the weather update for the location
            return View();
        }

    }

    internal class FromBodyAttribute : Attribute
    {
    }
}