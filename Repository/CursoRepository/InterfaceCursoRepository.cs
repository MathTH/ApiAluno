using ApiAluno.Models.Curso;

namespace ApiAluno.Repository.CursoRepository
{
    public interface InterfaceCursoRepository
    {
        Task<CursoModel>AdicionarCurso(CursoModel curso);
        Task<List<CursoModel>> BuscarTodosCurso();
        Task<CursoModel>BuscarCursoPorId(int id);
        Task<bool> ApagarCurso(int id);
    }
}
