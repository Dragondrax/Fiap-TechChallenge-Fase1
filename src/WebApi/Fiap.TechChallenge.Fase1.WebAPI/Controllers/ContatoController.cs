using Microsoft.AspNetCore.Mvc;

namespace Fiap.TechChallenge.Fase1.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }
        [HttpGet("Cadastrar")]
        public async Task<IActionResult> Cadastrar(ContatoDTO dto)
        {
            var retorno = _contatoService.SalvarContato(dto);
            return Ok("Teste");
        }
    }
}
