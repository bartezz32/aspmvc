using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  ControllersAndActions.Infrastructure;


namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        public void ReceiveForm(string name, string city) => new CustomHtmlResult
        {
            Content = $"{name} lives in {city}";
        };

    }
}