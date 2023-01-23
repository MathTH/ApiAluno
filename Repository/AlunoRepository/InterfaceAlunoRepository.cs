using ApiAluno.Models.Aluno;

namespace ApiAluno.Repository.AlunoRepository
{
    public interface InterfaceAlunoRepository
    {
        //Função para cadastrar um novo aluno
        Task<AlunoModel> AdicionarNovoAluno(AlunoModel aluno);
        
        //Função para pesquisar(buscar) todos os alunos
        Task<List<AlunoModel>> BuscarTodosAlunos();

        //Função para pesquisar(buscar) aluno pelo ID
        Task<AlunoModel> BuscarAlunoPorId(int id);

        //Função para editar algum dado de um aluno passando o ID
        Task<AlunoModel> EditarAluno(AlunoModel aluno, int id);
        
        //Função para apagar o meu aluno passando o ID
        Task<bool> ApagarAluno(int id);
    }
}
