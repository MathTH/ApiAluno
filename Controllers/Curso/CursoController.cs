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
        public async Task<ActionResult<List<CursoModel>>> BuscarTodosCurso(int id)
        {
            return Ok();
        }
    }
}
