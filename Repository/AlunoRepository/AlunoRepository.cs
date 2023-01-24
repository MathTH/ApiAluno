using ApiAluno.Data;
using ApiAluno.Models.Aluno;
using Microsoft.EntityFrameworkCore;

namespace ApiAluno.Repository.AlunoRepository
{
    public class AlunoRepository : InterfaceAlunoRepository
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public async Task<AlunoModel> AdicionarNovoAluno(AlunoModel aluno)
        {
          await  _bancoContext.Aluno.AddAsync(aluno);
          await _bancoContext.SaveChangesAsync();

            return aluno;
        }

        public async Task<AlunoModel> EditarAluno(AlunoModel aluno, int id)
        {
            AlunoModel alunoId = await BuscarAlunoPorId(id);

            if(alunoId == null)
            {
                throw new Exception($"ID: {id} não encontrado");

                
            }

            alunoId.Nome = aluno.Nome;
            alunoId.SobreNome = aluno.SobreNome;
            alunoId.Email = aluno.Email;
            alunoId.Idade = aluno.Idade;

            _bancoContext.Aluno.Update(alunoId);
            await _bancoContext.SaveChangesAsync();

            return alunoId;

        }

        public async Task<List<AlunoModel>> BuscarTodosAlunos()
        {
            return await _bancoContext.Aluno.ToListAsync();
        }

        public async Task<AlunoModel> BuscarAlunoPorId(int id)
        {
            return await _bancoContext.Aluno.FirstOrDefaultAsync(a => a.Id == id);
        }


        public async Task<bool> ApagarAluno(int id)
        {
            AlunoModel alunoId = await BuscarAlunoPorId(id);

            if(alunoId == null)
            {
                throw new Exception($"ID: {id} não encontrado");
            }

            _bancoContext.Aluno.Remove(alunoId);
            await  _bancoContext.SaveChangesAsync();

            return true;
        }
    }
}
