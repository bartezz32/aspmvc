using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infrastructure;
using Microsoft.Extensions.Logging;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        private ILogger<HomeController> logger;

        public HomeController(UptimeService up,ILogger<HomeController> log)
        { 
            uptime = up;
            logger = log;
        }
        public ViewResult Index(bool throwException = false)
        {
            logger.LogDebug($"Request {Request.Path}, {uptime.Uptime}ms");
            if (throwException)
            {
                throw new System.NullReferenceException();
            }

            return View(new Dictionary<string, string>
            {
                ["Message"] = "Index() action method",
                ["Uptime"] = $"{uptime.Uptime}"
            });
        }

        public ViewResult Error() => View(nameof(Index), new Dictionary<string, string>
        {
            ["Message"] = "Error() action method"
        });


    }
}