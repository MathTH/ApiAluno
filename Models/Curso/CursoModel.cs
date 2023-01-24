using ApiAluno.Enums.Curso;
using ApiAluno.Models.Aluno;

namespace ApiAluno.Models.Curso
{
    public class CursoModel
    {
        public int Id { get; set; }

        public int CursoId { get; set; }    
        public string? NomeCurso { get; set; }
        public int AlunoId { get; set; }
        //public  AlunoModel AlunoModel { get; set; }
        public DuracaoCursoEnum Duracao { get; set; }



    }
}
