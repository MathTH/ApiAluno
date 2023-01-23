using ApiAluno.Models.Aluno;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAluno.ConfigurationDB.AlunoConfigDB
{
    public class AlunoConfiguration : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {

            builder.ToTable("Alunos");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome).HasColumnType("VARCHAR(150)").HasColumnName("Nome").IsRequired();
            builder.Property(a => a.SobreNome).HasColumnType("VARCHAR(150)").HasColumnName("SobreNome").IsRequired();
            builder.Property(a => a.Email).HasColumnType("VARCHAR(150)").HasColumnName("Email").IsRequired();
            builder.Property(a => a.Idade).HasColumnName("Idade").IsRequired();
            builder.Property(a => a.CursoId).HasColumnName("CursoID").IsRequired();
            builder.Property(a => a.IniciadoEm).HasColumnName("CursoIniciadoEm").IsRequired();
            builder.Property(a => a.DeterminadoEm).HasColumnName("CursoDeterminadoEm").IsRequired();
        }
    }
}
