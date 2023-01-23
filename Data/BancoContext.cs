using ApiAluno.Models.Aluno;
using ApiAluno.Models.Curso;
using Microsoft.EntityFrameworkCore;

namespace ApiAluno.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<CursoModel> Curso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
