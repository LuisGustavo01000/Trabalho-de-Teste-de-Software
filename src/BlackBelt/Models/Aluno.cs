using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14)]
        [MinLength(14, ErrorMessage = "O CPF informado está incompleto!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
            
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateOnly Dt_Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Faixa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int? Id_Turma { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Dt_Matricula { get; set; }

        [ForeignKey("Id_Turma")]
        public Turma Turma { get; set; }

        public IEnumerable<Presenca> Presencas { get; set; }

        public IEnumerable<Habilidade> Habilidades { get; set; }
    }
}
