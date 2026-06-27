using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Avaliacao { get; set; }
        public int Id_Aluno { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
    }
}
