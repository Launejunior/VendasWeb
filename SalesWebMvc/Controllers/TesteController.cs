using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Saudacao"] = "Bem Vindo a Página TESTE";
            ViewData["Email"] = "email@xpto.com";
            return View();
        }
    }
}
