using Microsoft.AspNetCore.Mvc;
using ProjetoAluno.Dominio.Dominio;
using ProjetoAluno.Models;
using ProjetoAluno.Service.Service.Interface;

namespace ProjetoAluno.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(AlunoView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var aluno = new Aluno
                    {
                        NomeAluno = model.NomeAluno,
                        Nota1 = model.Nota1,
                        Nota2 = model.Nota2,
                        TotalNota = model.TotalNota,
                        Situacao = model.Situacao,
                        DataInicio = model.DataInicio,
                        DataTermino = model.DataTermino,
                        Escolaridade = model.Escolaridade,
                        Status = model.Status
                    };

                    _alunoService.Adicionar(aluno);
                    TempData["MensagemSucesso"] = "Aluno cadastrado com sucesso!";
                    return RedirectToAction("Cadastrar");
                }
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Erro ao cadastrar aluno.";
                Console.WriteLine("Erro: " + ex.Message);
            }

            return View(model); // volta com os dados preenchidos
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
