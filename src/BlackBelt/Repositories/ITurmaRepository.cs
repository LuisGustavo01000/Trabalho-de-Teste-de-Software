using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface ITurmaRepository
    {
        public IEnumerable<Turma> BuscarTodasTurmas();
        public IEnumerable<Turma> BuscarTurmasPresenca();
        public Turma CadastrarTurma(Turma turma);
        public void ExcluirTurma(int id);
        public Turma BuscarTurma(int id);
        public void EditarTurma(Turma turma);
    }
}
