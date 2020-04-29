using UrlsAndRoutes.Models;
using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index() => View("Result",
            new Result
            {
                Controller = nameof(AdminController),
                Action = nameof(Index)
            });
    }
}