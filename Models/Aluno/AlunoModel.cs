using ApiAluno.Models.Curso;

namespace ApiAluno.Models.Aluno
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public string? Email { get; set; }
        public int Idade { get; set; }
        public CursoModel Cursando { get; set; }

    }
}
