using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BlackBelt.Models;
using Microsoft.IdentityModel.Tokens;

namespace BlackBelt.Controllers
{
    public class RegistrarPresencaController : Controller
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IPresencaRepository _presencaRepository;
        public RegistrarPresencaController(ITurmaRepository turmaRepository, IAlunoRepository alunoRepository, IPresencaRepository presencaRepository)
        {
            _turmaRepository = turmaRepository;
            _alunoRepository = alunoRepository;
            _presencaRepository = presencaRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult Index()
        {
            try
            {
                IEnumerable<Turma> turmas = _turmaRepository.BuscarTurmasPresenca();
                return View(turmas);
            }
            catch (Exception ex)
            {
                TempData["ErroBuscarTurmas"] = "Não foi possível buscar as turmas. Tente Novamente mais tarde.";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult LancarPresenca(int id)
        {
            try
            {
                var alunos = _alunoRepository.BuscarAlunosPorTurma(id);
                ViewData["Alunos"] = alunos;
                List<Presenca> presencas = new List<Presenca>();
                foreach (var aluno in alunos)
                {
                    Presenca presenca = new Presenca
                    {
                        Id_Aluno = aluno.Id,
                        Id_Turma = id,
                        Presente = false,
                        Dt_Aula = DateTime.Today
                    };

                    presencas.Add(presenca);
                }
                return View(presencas);
            }
            catch (Exception ex)
            {
                TempData["ErroBuscarAlunos"] = "Não foi possível buscar os alunos. Tente Novamente mais tarde.";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult Registrar(List<Presenca> presencas)
        {
            try
            {
                _presencaRepository.LancarPresenca(presencas);
            }
            catch (Exception ex)
            {
                TempData["ErroLançarPresenca"] = "Não foi possível lançar presença. Tente Novamente mais tarde.";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult Historico(int id)
        {
            try
            {
                var aulas = _presencaRepository.BuscarPresencasPorTurma(id);
                return View(aulas);
            }
            catch(Exception ex)
            {

            }
            return View();
        }
    }
}
