using Microsoft.AspNetCore.Mvc;

namespace uninove.web.Controllers

{

    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>()
            {
                "Notebook",
                "Mouse",
                "Teclado",
                "Monitor",
                "Fone"
            };

            List<double> precos = new List<double>()
            {

                3500,
                80,
                150,
                900,
                200
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;
            return View();

        }
    }
}