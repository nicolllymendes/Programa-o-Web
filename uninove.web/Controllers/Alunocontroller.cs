
using Microsoft.AspNetCore.Mvc;
using uninove.web.Models;
namespace uninove.web.Controllers

{

    public class AlunoController : Controller
    {
        [HttpGet]

        public IActionResult Cadastro()

        {
            return View();
        }

        [HttpPost]

        public IActionResult Cadastro(Aluno aluno)

        {
            return View("Confirmacao", aluno);
        }

    }

}