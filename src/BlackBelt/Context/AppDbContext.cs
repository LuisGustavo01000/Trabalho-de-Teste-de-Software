using BlackBelt.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackBelt.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos  { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>()
                .HasOne(t => t.Instrutor)
                .WithMany(i => i.Turmas)
                .HasForeignKey(t => t.Id_Instrutor)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Turma)
                .WithMany(t => t.Alunos)
                .HasForeignKey(a => a.Id_Turma)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Presenca>()
                .HasOne(p => p.Turma)
                .WithMany(t => t.Presencas)
                .HasForeignKey(p => p.Id_Turma)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Presenca>()
                .HasOne(p => p.Aluno)
                .WithMany(a => a.Presencas)
                .HasForeignKey(p => p.Id_Aluno)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Habilidade>()
                .HasOne(h => h.Aluno)
                .WithMany(a => a.Habilidades)
                .HasForeignKey(h => h.Id_Aluno)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
