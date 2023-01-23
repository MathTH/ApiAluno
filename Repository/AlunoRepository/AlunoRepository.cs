using ApiAluno.Models.Aluno;

namespace ApiAluno.Repository.AlunoRepository
{
    public class AlunoRepository : InterfaceAlunoRepository
    {
        public Task<AlunoModel> AdicionarNovoAluno(AlunoModel aluno)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlunoModel>> BuscarTodosAlunos()
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> BuscarAlunoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> EditarAluno(AlunoModel aluno, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ApagarAluno(int id)
        {
            throw new NotImplementedException();
        }
    }
}
