using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        private readonly AppDbContext _context;
        public HabilidadeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Habilidade BuscarHabilidade(int id)
        {
            var habilidade = _context.Habilidades
                .FirstOrDefault(h => h.Id == id);

            if (habilidade != null)
            {
                return habilidade;
            }
            else
            {
                return null;
            }

            
        }

        public IEnumerable<Habilidade> BuscarHabilidades(int id)
        {
            return _context.Habilidades
                .Where(h => h.Id_Aluno == id)
                .ToList();
        }

        public void CadastrarHabilidade(Habilidade habilidade)
        {
            _context.Habilidades.Add(habilidade);
            _context.SaveChanges();
        }

        public void EditarHabilidade(Habilidade habilidade)
        {
            _context.Habilidades.Update(habilidade);
            _context.SaveChanges();
        }

        public void ExcluirHabilidade(Habilidade habilidade)
        {
            _context.Habilidades.Remove(habilidade);
            _context.SaveChanges();
        }
    }
}
