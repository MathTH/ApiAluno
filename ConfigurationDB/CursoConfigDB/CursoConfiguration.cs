using ApiAluno.Models.Curso;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAluno.ConfigurationDB.CursoConfigDB
{
    public class CursoConfiguration : IEntityTypeConfiguration<CursoModel>
    {
        public void Configure(EntityTypeBuilder<CursoModel> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(c => c.Id);      
            builder.Property(c => c.NomeCurso).HasColumnType("VARCHAR(150)").HasColumnName("NomeDoCurso").IsRequired();
            builder.Property(c => c.AlunoID).IsRequired();
            builder.Property(c => c.Duracao).IsRequired();
        }
    }
}
