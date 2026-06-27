using BlackBelt.Context;
using BlackBelt.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackBelt.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly AppDbContext _context;

        public PresencaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Presenca> BuscarPresencasPorTurma(int id)
        {
            return _context.Presencas
                    .Where(p => p.Id_Turma == id)
                    .Select(p => new Presenca
                    {
                        Dt_Aula = p.Dt_Aula
                    })
                    .Distinct()
                    .OrderBy(d => d.Dt_Aula);
        }

        public void LancarPresenca(List<Presenca> presencas)
        {
            foreach (var presenca in presencas)
            {
                _context.Presencas.Add(presenca);
                Console.WriteLine($"Aluno: {presenca.Id_Aluno}, Turma: {presenca.Id_Turma}, Presente: {presenca.Presente}");
                _context.SaveChanges();
            }
        }
    }
}
