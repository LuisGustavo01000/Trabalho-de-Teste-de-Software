using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    // Revisar código para implementar tratamento de exceção
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> BuscarInstrutores()
        {
            return _context.Usuarios
                .Where(u => u.Tipo_Usuario == "Instrutor")
                .OrderBy(a => a.Nome)
                .ToList();
        }

        public IEnumerable<Usuario> BuscarTodosUsuarios()
        {
            return _context.Usuarios
                .Select(u => new Usuario
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    Cpf = u.Cpf,
                    Telefone = u.Telefone,
                    Dt_Nascimento = u.Dt_Nascimento,
                    Tipo_Usuario = u.Tipo_Usuario
                })
                .OrderBy(u => u.Nome);
        }

        public Usuario BuscarUsuario(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                return null;
            }

        }

        public Usuario BuscarUsuarioLogin(string cpf, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Cpf == cpf);
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                return null;
            }

        }

        public Usuario CadastrarUsuario(Usuario usuario)
        {
            if (VerificarCpf(usuario.Cpf))
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public Usuario EditarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public void ExcluirUsuario(int id)
        {
            var usuario = BuscarUsuario(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        private bool VerificarCpf(string cpf)
        {
            //Se ele retornar false não deixará cadastrar o Aluno
            if (_context.Usuarios.SingleOrDefault(a => a.Cpf == cpf) != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
