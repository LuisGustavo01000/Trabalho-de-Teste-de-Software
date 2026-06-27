using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index(string filtroNome, string filtroTipo)
        {
            var usuarios = _usuarioRepository.BuscarTodosUsuarios();

            if (!string.IsNullOrEmpty(filtroNome))
                usuarios = usuarios.Where(u => u.Nome.Contains(filtroNome, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(filtroTipo))
                usuarios = usuarios.Where(u => u.Tipo_Usuario.Equals(filtroTipo, StringComparison.OrdinalIgnoreCase));

            ViewBag.FiltroNome = filtroNome;
            ViewBag.FiltroTipo = filtroTipo;

            return View(usuarios);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            try
            {
                //removendo mascara do cpf
                usuario.Cpf = new string(usuario.Cpf.Where(char.IsDigit).ToArray());

                // removendo mascara do telefone
                usuario.Telefone = new string(usuario.Telefone.Where(char.IsDigit).ToArray());

                usuario.SenhaHash = CriptografiaSenha.SenhaHash(usuario.Senha);
                usuario.Senha = null;
                if (_usuarioRepository.CadastrarUsuario(usuario) != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErroCpfUsuario"] = "Já existe um usuário com este cpf!";
                    return RedirectToAction("Cadastro");
                }

            }
            catch (Exception ex)
            {
                TempData["ErroCadastroUsuario"] = "Não foi possível cadastrar usuário. Tente Novamente mais tarde.";
                return RedirectToAction("Cadastro");
            }

        }

        [Authorize(Roles = "Admin")]
        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepository.BuscarUsuario(id);
            return View(usuario);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult EditarUsuario(Usuario usuario)
        {
            try
            {
                _usuarioRepository.EditarUsuario(usuario);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroEditarUsuario"] = "Não foi possível editar usuário. Tente Novamente mais tarde.";
                return RedirectToAction("Index");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Excluir(int id)
        {
            var usuario = _usuarioRepository.BuscarUsuario(id);
            if (usuario != null)
            {
                return View(usuario);
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult ExcluirUsuario(int id)
        {
            try
            {
                _usuarioRepository.ExcluirUsuario(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroExcluirUsuario"] = "Não foi possível excluir usuário. Tente Novamente mais tarde.";
                return RedirectToAction("Index");
            }

        }
    }
}
