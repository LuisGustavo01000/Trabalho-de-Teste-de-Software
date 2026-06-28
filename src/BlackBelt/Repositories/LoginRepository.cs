using BlackBelt.Models;
using BlackBelt.Context;

namespace BlackBelt.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AppDbContext _context;

        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }

        public Login RegistrarLogin(Usuario usuario)
        {
            Login perfil = new Login(usuario.Id,usuario.Cpf,usuario.Nome, DateTime.Now);
            _context.Logins.Add(perfil);
            _context.SaveChanges();
            return perfil;
        }
    }
}
