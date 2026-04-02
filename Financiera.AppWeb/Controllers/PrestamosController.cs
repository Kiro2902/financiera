using Microsoft.AspNetCore.Mvc;

namespace Financiera.AppWeb.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
