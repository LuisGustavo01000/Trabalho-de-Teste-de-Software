using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Presenca
    {
        public int Id { get; set; }
        public int Id_Turma { get; set; }
        public int Id_Aluno { get; set; }

        //Se o status for true o aluno esteve presente se for false ele faltou
        public bool Presente { get; set; }
        public DateTime Dt_Aula { get; set; }

        [ForeignKey("Id_Turma")]
        public Turma? Turma { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno? Aluno { get; set; }
    }
}
