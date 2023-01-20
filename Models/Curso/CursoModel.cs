using ApiAluno.Enums.Curso;
using ApiAluno.Models.Aluno;

namespace ApiAluno.Models.Curso
{
    public class CursoModel
    {
        public int Id { get; set; }
        public string? NomeCurso { get; set; }
        public AlunoModel IdAluno { get; set; }
        public DuracaoCursoEnum Duracao { get; set; }



    }
}
