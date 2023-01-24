using ApiAluno.Models.Aluno;
using ApiAluno.Repository.AlunoRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAluno.Controllers.Aluno
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly InterfaceAlunoRepository _alunoRepository;

        public AlunoController (InterfaceAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository; 
        }

        [HttpPost]
        public async Task<ActionResult<AlunoModel>> AdicionarAluno ([FromBody] AlunoModel alunoModel)
        {
            AlunoModel aluno = await _alunoRepository.AdicionarNovoAluno(alunoModel);

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AlunoModel>> EditarAluno ([FromBody] AlunoModel alunoModel, int id)
        {
            alunoModel.Id = id;
            AlunoModel aluno = await _alunoRepository.EditarAluno(alunoModel, id);
            return Ok(aluno);
        }

        [HttpGet]
        public async Task<ActionResult<List<AlunoModel>>> BuscarTodosAlunos()
        {
            List<AlunoModel> aluno = await _alunoRepository.BuscarTodosAlunos();
            return Ok(aluno);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoModel>> BuscarAlunoPeloID(int id)
        {

            AlunoModel aluno = await _alunoRepository.BuscarAlunoPorId(id);
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AlunoModel>> ApagarAluno(int id)
        {
            bool apagarAluno = await _alunoRepository.ApagarAluno(id);
            return Ok(apagarAluno);
        }
    }
}
