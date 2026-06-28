using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface ILoginRepository
    {
        public Login RegistrarLogin(Usuario usuario);
    }
}
