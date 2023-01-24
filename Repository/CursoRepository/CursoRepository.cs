using ApiAluno.Data;
using ApiAluno.Models.Curso;
using Microsoft.EntityFrameworkCore;

namespace ApiAluno.Repository.CursoRepository
{
    public class CursoRepository : InterfaceCursoRepository
    {

        private readonly BancoContext _bancoContext;
        public CursoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public async Task<CursoModel> AdicionarCurso(CursoModel curso)
        {
            await _bancoContext.Curso.AddAsync(curso);
            await _bancoContext.SaveChangesAsync();

            return curso;
        }

        public async Task<CursoModel> BuscarCursoPorId(int id)
        {
            return  await _bancoContext.Curso.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CursoModel>> BuscarTodosCurso()
        {
            return await _bancoContext.Curso.ToListAsync();
        }

        public async Task<bool> ApagarCurso(int id)
        {
            CursoModel curso = await BuscarCursoPorId(id);
            if(curso == null)
            {
                throw new Exception($"ID:{id} não encontrado");
            }
             _bancoContext.Curso.Remove(curso);
            await _bancoContext.SaveChangesAsync();

            return true;
        }


    }
}
