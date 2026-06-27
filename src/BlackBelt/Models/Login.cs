using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Cpf { get; set; }
        public string Perfil { get; set; }
        public DateTime Dt_Login { get; set; } = DateTime.Now;

        [ForeignKey("Id_Usuario")]
        public Usuario Usuario { get; set; }

        public Login(int id_Usuario, string cpf, string perfil, DateTime dt_Login)
        {
            Id_Usuario = id_Usuario;
            Cpf = cpf;
            Perfil = perfil;
            Dt_Login = dt_Login;
        }
    }
}
