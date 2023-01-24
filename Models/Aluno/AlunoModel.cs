using ApiAluno.Models.Curso;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAluno.Models.Aluno
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public string? Email { get; set; }
        public int Idade { get; set; }
        //public List<CursoModel>? CursoId { get; set; }2
        public DateTime? IniciadoEm { get; set; }   
        public DateTime? DeterminadoEm { get; set; }
    }
}
