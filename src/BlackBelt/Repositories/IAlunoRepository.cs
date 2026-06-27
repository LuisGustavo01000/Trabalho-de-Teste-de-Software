using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IAlunoRepository
    {
        public IEnumerable<Aluno> BuscarTodosAlunos();
        public Aluno CadastrarAluno(Aluno aluno);
        public void ExcluirAluno(int id);
        public Aluno BuscarAluno(int id);
        public IEnumerable<Aluno> BuscarAlunosPorTurma(int id_turma);
        public Aluno EditarAluno(Aluno aluno);
    }
}
