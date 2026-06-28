using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IHabilidadeRepository
    {
        public IEnumerable<Habilidade> BuscarHabilidades(int id);
        public Habilidade BuscarHabilidade(int id);
        public void CadastrarHabilidade(Habilidade habilidade);
        public void ExcluirHabilidade(Habilidade habilidade);
        public void EditarHabilidade(Habilidade habilidade);
    }
}
