using ApiAluno.Models.Curso;
using ApiAluno.Repository.CursoRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAluno.Controllers.Curso
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        public readonly InterfaceCursoRepository _interfaceCursoRepository;

        public CursoController(InterfaceCursoRepository interfaceCursoRepository)
        {
            _interfaceCursoRepository = interfaceCursoRepository;       
        }

        [HttpPost]
        public async Task<ActionResult<CursoModel>> AdicionarCurso ([FromBody] CursoModel cursoModel)
        {
            CursoModel curso = await _interfaceCursoRepository.AdicionarCurso(cursoModel);
            return Ok(curso);
        }
        
        [HttpGet]
        public async Task<ActionResult<List<CursoModel>>> BuscarTodosCurso()
        {
            List<CursoModel> curso = await _interfaceCursoRepository.BuscarTodosCurso();
            return Ok (curso);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoModel>> BuscarCursoPorID(int id)
        {
            CursoModel curso = await _interfaceCursoRepository.BuscarCursoPorId(id);
            return Ok (curso);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CursoModel>> DeletarCurso(int id)
        {
            bool apagarCurso = await _interfaceCursoRepository.ApagarCurso(id);
            return Ok(apagarCurso);
        }
    }
}
