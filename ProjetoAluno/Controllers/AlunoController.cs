using Microsoft.AspNetCore.Mvc;

namespace ProjetoAluno.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        public IActionResult ListarAtivos()
        {
            return View();
        }

        public IActionResult ListarInativos()
        {
            return View();
        }
    }
}
