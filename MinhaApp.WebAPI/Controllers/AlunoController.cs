using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaApp.Dominio;
using MinhaApp.Servico;
using MinhaApp.Servico.DTOs;

namespace MinhaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoServico _alunoServico;

        public AlunoController(IAlunoServico alunoServico)
        {
            _alunoServico = alunoServico;
        }

        [HttpPost]
        public IActionResult AdicionarAluno([FromBody] AlunoDto alunoDto)
        {
            bool aprovado = _alunoServico.AdicionarAluno(alunoDto);
            return Ok(aprovado);
        }

        [HttpGet]
        public IActionResult ListarAlunos()
        {
            var alunos = _alunoServico.ListarAlunos();
            return Ok(alunos);
        }
    }
}
