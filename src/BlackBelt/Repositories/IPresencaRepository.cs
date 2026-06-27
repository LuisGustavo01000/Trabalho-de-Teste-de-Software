using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IPresencaRepository
    {
        public void LancarPresenca(List<Presenca> presencas);
        public IEnumerable<Presenca> BuscarPresencasPorTurma(int id);
    }
}
