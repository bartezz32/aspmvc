using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Erro() => View();
    }

}