using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Turma
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigtório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigtório")]
        public int? Id_Instrutor{ get; set; }

        [Required(ErrorMessage = "Campo obrigtório")]
        public TimeOnly Horario { get; set; }
        public int Status { get; set; }
        public DateTime Dt_Cadastro { get; set; }

        [ForeignKey("Id_Instrutor")]
        public Usuario Instrutor { get; set; }

        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<Presenca> Presencas { get; set; }
    }
}
