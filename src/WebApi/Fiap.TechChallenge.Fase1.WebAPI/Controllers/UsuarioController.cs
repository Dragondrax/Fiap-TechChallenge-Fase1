﻿using Fiap.TechChallenge.Fase1.Dominio;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Usuario;
using Fiap.TechChallenge.Fase1.SharedKernel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.TechChallenge.Fase1.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("CriarUsuario")]
        public async Task<IActionResult> SalvarNovoUsuario(CriarUsuarioDTO usuario)
        {
            var resultado = await _usuarioService.SalvarUsuario(usuario);
            if (resultado.Sucesso == true)
                return Ok(resultado);
            else if (resultado.Sucesso == false && resultado.Objeto is null && resultado.Mensagem.Any(x => String.IsNullOrEmpty(x)))
                return StatusCode(500, MensagemErroGenerico.MENSAGEM_ERRO_500);
            else
                return BadRequest(resultado);
        }

        [HttpPost("Autenticar")]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar(AutenticarUsuarioDTO usuario)
        {
            var resultado = await _usuarioService.AutenticarUsuario(usuario);
            if (resultado.Sucesso == true)
                return Ok(resultado);
            else if (resultado.Sucesso == false && resultado.Objeto is null && resultado.Mensagem.Any(x => String.IsNullOrEmpty(x)))
                return StatusCode(500, MensagemErroGenerico.MENSAGEM_ERRO_500);
            else
                return BadRequest(resultado);
        }

    }
}
